// Controlador que contiene la logica de la pagina html
(function () {
    // creamos el modulo LoginModule que recibe como inyeccion de dependencias el modulo SifBranch
    var app = angular.module('LoginModule', ['SifBranch']);
    // se crea el controlador LoginController el cual racibe como parametro el $scope y el $http
    app.controller('LoginController', ['$scope', '$http', function ($scope, $http) {
        // obtenemos el dictionary del modulo SifBranch que obtenemos por medio de inyeccion de dependencias 
        this.dictionary = dictionary;
        console.log(this.dictionary);
        // funcion que se acciiona al presionar el boton DE INICIAR
        this.submit = function () {
            // se invocara el metodo que es un metodo global que exite en la libreria httpHelper
            // y le estamos pasando algunos parametros
            webApiInvoke("security", "Login", $http, $scope, onSuccess = function () {
                console.log("Login exitoso")
            },
            onRejected = function () {
                    showMessage($http, $scope, "12345", onClose = function () {
                        console.log("Modal cerrado")
                    }, null);
            });
        };
        // funcion que se acciiona al presionar el boton
        this.cancel = function () {
            console.log("hola");
        };
    }
    ]);

})();

