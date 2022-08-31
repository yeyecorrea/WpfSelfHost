// Modelos
var dictionary = {
    security: {
        userLogon: "",
        userPassword: ""
    }
};

// Modulo
(function () {
    var app = angular.module('SifBranch', []);

    app.directive('userName', function () {
        return {
            restrict: 'E',
            templateUrl: 'components/UserName.html'
        };

    });

    app.directive('userPassword', function () {
        return {
            restrict: 'E',
            templateUrl: 'components/UserPassword.html'
        };
    });

})();