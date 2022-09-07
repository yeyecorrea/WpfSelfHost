// Modelos
/*
 Estamos creando un objeto llamadao dictionary, que contiene otro objeto llamado security
 y este a su vez tiene dos campos userLogon y userPassword, este inicialmente nos va a servir 
 como modelo para los componentes
 */
var dictionary = {
    security: {
        userLogon: "yeferson",
        userPassword: "123456789"
    }
};

// Modulo
(function () {
    var app = angular.module('SifBranch', []);
    // Registramos las directivas username
    app.directive('userName', function () {
        return {
            // se define el nombre que van a tener E: Solo deben emparejar el nombre
            restrict: 'E',
            // template donde va a obtener las directivas en html
            templateUrl: 'components/UserName.html'
        };

    });
    // dierectiva userPassword
    app.directive('userPassword', function () {
        return {
            // se define el nombre que van a tener E: Solo deben emparejar el nombre
            restrict: 'E',
            // template donde va a obtener las directivas en html
            templateUrl: 'components/UserPassword.html'
        };
    });

})();