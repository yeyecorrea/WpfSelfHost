// contiene metodos y funciones que nos permitewn interactuar con bootstrap
function showMessage($http, $scope, messageCode, closeAction, replacements) {
    //if ($("element").data('bs.modal')?.isShown) {
        SIF = $scope.SIF;
        SIF.errorCode = messageCode;
        SIF.errorMessage = "Error algo ocurrio";
        $("#errorDialog").unbind("shown.bs.modal");
        $("#errorDismiss").unbind("keypress");
        $("#errorDismiss").unbind("click");
        $("#errorDialog").on('shown.bs.modal', function () {
            $("#errorDismiss").focus();
            $("#errorDismiss").on("keypress click", function (e) {
                if (e.which == 13 || e.which == 27 || e.which == 32 || e.type == "click") {
                    $("#errorDialog").modal("hide");
                    if (closeAction != null && closeAction != undefined) {
                        $scope.$apply(function () {
                            closeAction();
                            closeAction = null;
                        });
                    }
                }
            });
        });
        $("#errorDialog").modal();
    //}
}