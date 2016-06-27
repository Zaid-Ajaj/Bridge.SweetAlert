using Bridge;

namespace Bridge.SweetAlert
{
    [Enum(Emit.StringNameLowerCase)]
    public enum SweetAlertType
    {
        Success,
        Error,
        Warning, 
        Info, 
        Input
    }
}