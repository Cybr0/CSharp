using System;

namespace HelloApp
{
    public class User : IDisposable
    {
        private bool disposed = false;

        // реализация интерфейса IDisposable
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // освобождаем управляемые ресурсы
                }
                // освобождаем неуправляемые ресурсы
                disposed = true;
            }
        }
        // определяем деструктор
        ~User()
        {
            Dispose(false);
        }
    }
}
