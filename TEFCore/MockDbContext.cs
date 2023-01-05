using Microsoft.EntityFrameworkCore;

namespace TEFCore;

public sealed class MockDbContext<T> : IDisposable
    where T : DbContext
{
    private T _context;
    private bool _disposed;

    public T DbContext => _context;

    internal MockDbContext(T dbContext)
    {
       _context = dbContext;
    }

    public void SeedDataBase(Action<T> seedAction)
    {
        seedAction(_context);
        _context.SaveChanges();
    }

    public async Task SeedDataBaseAsync(Func<T, Task> seedActionAsync)
    {
        await seedActionAsync(_context);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

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