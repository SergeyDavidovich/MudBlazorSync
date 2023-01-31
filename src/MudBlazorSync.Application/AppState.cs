using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazorSync.Application
{
    public class AppState
    {
        public string Hello { get => "Hello from AppState!"; }

        public bool IsDarkTheme { get; private set; } = false;

        public event Action? OnChange;

        public void SetDarkTheme(bool isdark)
        {
            IsDarkTheme = isdark;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
