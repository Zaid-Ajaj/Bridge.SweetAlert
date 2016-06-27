using Bridge;
using Bridge.Html5;
using Bridge.SweetAlert;

namespace Bridge.SweetAlert.Examples
{
    public class App
    {
        static void OnConfirmed(bool confirmed)
        {
            if (confirmed)
                SweetAlert.Success("Deleted!", "Your imaginary file has been deleted.");
            else
                SweetAlert.Error("Cancelled", "Your imaginary file is safe :)");
        }

        static void OnInputConfirmed(string inputValue)
        {
            if (inputValue == "")
                SweetAlert.ShowInputError("You need to write something!");
            else
                SweetAlert.Success("Nice!", "you wrote: " + inputValue);
        }

        public static void Main()
        {
            var confirmButton = new HTMLButtonElement
            {
                InnerHTML = "Delete file conformation",
                OnClick = (ev) =>
                {
                    SweetAlert.Show(new SweetAlertOptions
                    {
                        Title = "Are you sure?",
                        Text = "You will not be able to recover this imaginary file!",
                        Type = SweetAlertType.Warning,
                        ShowCancelButton = true,
                        ConfirmButtonColor = "#DD6B55",
                        ConfirmButtonText = "Yes, delete it!",
                        CancelButtonText = "No, cancel please",
                        CloseOnConfirm = false,
                        CloseOnCancel = false
                    }, OnConfirmed);
                }
            };

            var promptButton = new HTMLButtonElement
            {
                InnerHTML = "Prompt example",
                OnClick = (ev) =>
                {
                    SweetAlert.Show(new SweetAlertOptions
                    {
                        Title = "An input!",
                        Text = "Write something interesting:",
                        Type = SweetAlertType.Input,
                        ShowCancelButton = true,
                        CloseOnConfirm = false,
                        Animation = "slide-from-top",
                        InputPlaceholder = "Write something"
                    }, OnInputConfirmed); 
                }
            };
            // Add the Button to the page
            Document.Body.AppendChild(confirmButton);
            Document.Body.AppendChild(promptButton);
        }
    }
}