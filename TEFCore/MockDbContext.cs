// <copyright file="MockDbContext.cs" company="CAPV">
// Copyright (c) CAPV. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;

namespace TEFCore;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public sealed class MockDbContext<T> : IDisposable
    where T : DbContext
{
    private readonly T _context;
    private bool _disposed;

    public T DbContext => _context;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContext"></param>
    internal MockDbContext(T dbContext)
    {
       _context = dbContext;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="seedAction"></param>
    public void SeedDataBase(Action<T> seedAction)
    {
        seedAction(_context);
        _context.SaveChanges();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="seedActionAsync"></param>
    /// <returns></returns>
    public async Task SeedDataBaseAsync(Func<T, Task> seedActionAsync)
    {
        await seedActionAsync(_context);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <inheritdoc/>
    protected void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        _disposed = true;
    }
}