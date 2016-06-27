using Bridge;
using System;

namespace Bridge.SweetAlert
{
    [External]
    [Namespace(false)]
    public static class SweetAlert
    {
        [Template("swal({0}, {1}, 'success')")]
        public static extern void Success(string title, string message);

        [Template("swal({0}, {1}, 'error')")]
        public static extern void Error(string title, string message);

        [Template("swal({0}, {1}, 'warning')")]
        public static extern void Warning(string title, string message);

        [Template("swal({0}, {1}, 'info')")]
        public static extern void Info(string title, string message);

        [Template("swal({0})")]
        public static extern void Show(string title);

        [Template("swal({0}, {1})")]
        public static extern void Show(string title, string message);

        [Template("swal({0}, {1}, {2})")]
        public static extern void Show(string title, string mesage, SweetAlertType type);

        [Template("swal({0})")]
        public static extern void Show(SweetAlertOptions options);

        [Template("swal({0}, {1})")]
        public static extern void Show(SweetAlertOptions options, Action callback);

        [Template("swal({0}, {1})")]
        public static extern void Show(SweetAlertOptions options, Action<bool> callback);

        [Template("swal({0}, {1})")]
        public static extern void Show(SweetAlertOptions options, Action<string> callback);

        [Template("swal.setDefaults({0})")]
        public static extern void SetDefaults(SweetAlertOptions options);

        [Template("swal.close()")]
        public static extern void Close();

        [Template("swal.showInputError({0})")]
        public static extern void ShowInputError(string message);
        
        [Template("swal.enableButtons()")]
        public static extern void EnableButtons();

        [Template("swal.disableButtons()")]
        public static extern void DisableButtons();
    }
}