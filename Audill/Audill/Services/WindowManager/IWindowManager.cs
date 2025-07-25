namespace Audill.Services.WindowManager;

public interface IWindowManager
{
    void Show<TViewModel>();
    void ShowDialog<T>();
}