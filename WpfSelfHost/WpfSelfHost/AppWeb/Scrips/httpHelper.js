function webApiInvoke(productName, webapiurl, $http, $scope, successAction, rejectionAction) {
    // Estamos creando una referencia del controlador, que el alias es con SIF
    var SIF = $scope.SIF;
    // este metodo ejecuta el post que recibe la url del servidory  lo invocamos con parametros 
    // como el timeout de 30 por si hay demora se genere un error
    $http.post("http://localhost:9000/" + webapiurl,
        { timeout: 3000, params: SIF })
        // el metodo .them vamos a validar cuando el servicio haya sido exitoso, tambien invoca el metodo
        // processWebInvoke
        .then(function successCallback(response) {
            console.log(response);
            processResponseWebApiInvoke(webapiurl, response, $http, $scope, successAction, rejectionAction)
        }, function errorCallback(response) {
            console.log(response);
        });
}

function processResponseWebApiInvoke(webapiurl, response, $http, $scope, successAction, rejectionAction) {
    // validaqmos que el tipo de objeto data no sea un string, debe ser un objeto de SifWebResponse
    if (typeof (response.data) != "string") {
        // se valida que el campo State sea0, que es Accepted, si es asi, se valida que el parametro successAction no sea indefinido
        // o nulo
        if (response.data.State == 0) {
            if (successAction != undefined && successAction != null) {
                successAction.call($scope.SIF);
            }
        }
        else {
            if (rejectionAction != null && rejectionAction != undefined) {
                $scope.SIF.Message = response.data.Message;
                rejectionAction.call($scope.SIF);

            }
        }
    }
}