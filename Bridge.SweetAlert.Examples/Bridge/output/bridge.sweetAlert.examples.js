(function (globals) {
    "use strict";

    Bridge.define('Bridge.SweetAlert.Examples.App', {
        statics: {
            config: {
                init: function () {
                    Bridge.ready(this.main);
                }
            },
            onConfirmed: function (confirmed) {
                if (confirmed) {
                    swal("Deleted!", "Your imaginary file has been deleted.", 'success');
                }
                else  {
                    swal("Cancelled", "Your imaginary file is safe :)", 'error');
                }
            },
            onInputConfirmed: function (inputValue) {
                if (Bridge.referenceEquals(inputValue, "")) {
                    swal.showInputError("You need to write something!");
                }
                else  {
                    swal("Nice!", "you wrote: " + inputValue, 'success');
                }
            },
            main: function () {
                var confirmButton = Bridge.merge(document.createElement('button'), {
                    innerHTML: "Delete file conformation",
                    onclick: $_.Bridge.SweetAlert.Examples.App.f1
                } );
    
                var promptButton = Bridge.merge(document.createElement('button'), {
                    innerHTML: "Prompt example",
                    onclick: $_.Bridge.SweetAlert.Examples.App.f2
                } );
                // Add the Button to the page
                document.body.appendChild(confirmButton);
                document.body.appendChild(promptButton);
            }
        },
        $entryPoint: true
    });
    
    var $_ = {};
    
    Bridge.ns("Bridge.SweetAlert.Examples.App", $_);
    
    Bridge.apply($_.Bridge.SweetAlert.Examples.App, {
        f1: function (ev) {
            swal({ title: "Are you sure?", text: "You will not be able to recover this imaginary file!", type: "warning", showCancelButton: true, confirmButtonColor: "#DD6B55", confirmButtonText: "Yes, delete it!", cancelButtonText: "No, cancel please", closeOnConfirm: false, closeOnCancel: false }, Bridge.SweetAlert.Examples.App.onConfirmed);
        },
        f2: function (ev) {
            swal({ title: "An input!", text: "Write something interesting:", type: "input", showCancelButton: true, closeOnConfirm: false, animation: "slide-from-top", inputPlaceholder: "Write something" }, Bridge.SweetAlert.Examples.App.onInputConfirmed);
        }
    });
    
    Bridge.init();
})(this);
