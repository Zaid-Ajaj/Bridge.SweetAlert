using Bridge;

namespace Bridge.SweetAlert
{
    [ObjectLiteral]
    public class SweetAlertOptions
    {
        /// <summary>
        /// The title of the modal. It can either be added to the object under the key "title" or passed as the first parameter of the function.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// A description for the modal. It can either be added to the object under the key "text" or passed as the second parameter of the function.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The type of the modal. SweetAlert comes with 4 built-in types which will show a corresponding icon animation: "warning", "error", "success" and "info". You can also set it as "input" to get a prompt modal. It can either be put in the object under the key "type" or passed as the third parameter of the function.
        /// </summary>
        public SweetAlertType Type { get; set; }
        /// <summary>
        /// If set to true, the user can dismiss the modal by pressing the Escape key.
        /// </summary>
        public bool AllowEscapeKey { get; set; }
        /// <summary>
        /// A custom CSS class for the modal. It can be added to the object under the key "customClass".
        /// </summary>
        public string CustomClass { get; set; }
        /// <summary>
        /// If set to true, the user can dismiss the modal by clicking outside it.
        /// </summary>
        public bool AllowOutsideClick { get; set; }
        /// <summary>
        /// If set to false, the "OK/Confirm"-button will be hidden. Make sure you set a timer or set allowOutsideClick to true when using this, in order not to annoy the user.
        /// </summary>
        public bool ShowConfirmButton { get; set; }
        /// <summary>
        /// If set to true, a "Cancel"-button will be shown, which the user can click on to dismiss the modal.
        /// </summary>
        public bool ShowCancelButton { get; set; }
        /// <summary>
        /// Use this to change the text on the "Confirm"-button. If showCancelButton is set as true, the confirm button will automatically show "Confirm" instead of "OK".
        /// </summary>
        public string ConfirmButtonText { get; set; }
        /// <summary>
        /// Use this to change the background color of the "Confirm"-button (must be a HEX value).
        /// </summary>
        public string ConfirmButtonColor { get; set; }
        /// <summary>
        /// Use this to change the text on the "Cancel"-button.
        /// </summary>
        public string CancelButtonText { get; set; }
        /// <summary>
        /// Set to false if you want the modal to stay open even if the user presses the "Confirm"-button. This is especially useful if the function attached to the "Confirm"-button is another SweetAlert.
        /// </summary>
        public bool CloseOnConfirm { get; set; }
        /// <summary>
        /// Same as closeOnConfirm, but for the cancel button.
        /// </summary>
        public bool CloseOnCancel { get; set; }
        /// <summary>
        /// Add a customized icon for the modal. Should contain a string with the path to the image.
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// If imageUrl is set, you can specify imageSize to describes how big you want the icon to be in px. Pass in a string with two values separated by an "x". The first value is the width, the second is the height.
        /// </summary>
        public string ImageSize { get; set; }
        /// <summary>
        /// Auto close timer of the modal. Set in ms (milliseconds).
        /// </summary>
        public int Timer { get; set; }
        /// <summary>
        /// If set to true, will not escape title and text parameters. (Set to false if you're worried about XSS attacks.)
        /// </summary>
        public bool Html { get; set; }
        /// <summary>
        /// If set to false, the modal's animation will be disabled. Possible (string) values : pop (default when animation set to true), slide-from-top, slide-from-bottom
        /// </summary>
        public Any<bool, string> Animation { get; set; }
        /// <summary>
        /// Change the type of the input field when using type: "input" (this can be useful if you want users to type in their password for example).
        /// </summary>
        public string InputType { get; set; }
        /// <summary>
        /// When using the input-type, you can specify a placeholder to help the user.
        /// </summary>
        public string InputPlaceholder { get; set; }
        /// <summary>
        /// Specify a default text value that you want your input to show when using type: "input"
        /// </summary>
        public string InputValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowLoaderOnConfirm { get; set; }

    }
}