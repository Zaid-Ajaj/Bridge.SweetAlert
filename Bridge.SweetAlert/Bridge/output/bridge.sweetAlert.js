﻿(function (globals) {
    "use strict";

    Bridge.define('Bridge.SweetAlert.SweetAlertType', {
        statics: {
            success: 0,
            error: 1,
            warning: 2,
            info: 3,
            input: 4
        },
        $enum: true
    });
    
    Bridge.init();
})(this);
