function webApiInvoke(productName, webapiurl, $http, $scope, successAction, rejectionAction) {
    var SIF = $scope.SIF;

    $htt.post("http://localhost:9000/" + webapiurl,
        { timeout: 3000, params: SIF.dictionar })
        .then(function successCallback(response) {
            console.log(response);
            processResponseWebApiInvoke(webapiurl, response, $http, $scope, successAction, rejectionAction)
        }, function errorCallback(response) {
            console.log(response);
        });
}

function processResponseWebApiInvoke(webapiurl, response, $http, $scope, successAction, rejectionAction) {

}