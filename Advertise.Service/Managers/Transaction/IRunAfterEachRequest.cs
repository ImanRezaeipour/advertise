namespace Advertise.Service.Managers.Transaction
{
    /// <summary>
    ///     اجرای وظایف بعد از اینکه درخواستی فراخوانی (ارسال) شد
    /// </summary>
    public interface IRunAfterEachRequest
    {
        /// <summary>
        /// </summary>
        void Execute();
    }
}