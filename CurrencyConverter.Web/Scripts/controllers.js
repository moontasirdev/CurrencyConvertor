'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/

angular.module('app.controllers', [])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', 'restBackend', '$interval', function ($scope, $location, $window, restBackend, $interval) {
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        

        $scope.fromAmount = 0.00;
        $scope.toAmount = 0.00;
        $scope.currencyMap = undefined;

        $scope.selectedFromCurrency = '';
        $scope.selectedToCurrency = 0;
        $scope.allFromCurrency = [];
        $scope.allToCurrency = [];
        $scope.fromCurrencyChanged = function () {
            $scope.selectedToCurrency = 0;
            $scope.allToCurrency.length = 0;
            if ($scope.currencyMap && $scope.currencyMap.length > 0) {
                _.each($scope.currencyMap, function (item) {
                    if ($scope.selectedFromCurrency === item.FromCurrencyName) {
                        $scope.allToCurrency.push({ value: item.ExchangeRate, label: item.ToCurrencyName });
                    }
                });
            }
        };

        $scope.convert = function () {
            if ($scope.selectedFromCurrency && $scope.fromAmount && $scope.selectedToCurrency) {
                $scope.toAmount = $scope.fromAmount * $scope.selectedToCurrency;

               // $scope.toAmount = parseFloat(Math.round($scope.toAmount * 100) / 100).toFixed(2);
            }
        };



        var getExchangeRates = function() {
            restBackend.getExchangeRates().then(function (data) {
                $scope.currencyMap = data.response;
                var fromCurrency = _.uniq(_.pluck(data.response, 'FromCurrencyName'));

                _.each(fromCurrency, function (item) {
                    $scope.allFromCurrency.push({ value: item, label: item });
                });

            });
        }
    
        getExchangeRates();

        var interval = $interval(function () {
            console.log('say hello');
            getExchangeRates();
        }, 1000 *60 *10);


        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /about
    .controller('AboutCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA | About';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /login
    .controller('LoginCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA | Sign In';
        // TODO: Authorize a user
        $scope.login = function () {
            $location.path('/');
            return false;
        };
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);