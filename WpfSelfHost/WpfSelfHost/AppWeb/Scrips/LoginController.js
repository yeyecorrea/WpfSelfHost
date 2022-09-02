(function () {
    var app = angular.module('LoginModule', ['SifBranch']);
    app.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
        this.dictionary = dictionary;
        console.log(this.dictionary);

        this.submit = function () {
            console.log(this.dictionary);
            webApiInvoke("security", "Login", $http, $scope, onSucces = function () {
                console.log("Login exitoso")
            },
            onRejected = function () {
                  console.log("Login rechazado")
            });
        };

        this.cancel = function () {
            console.log("hola");
        };
    }
    ]);

})();

