namespace TreasureHunt {

    angular.module('TreasureHunt', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: TreasureHunt.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: TreasureHunt.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: TreasureHunt.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: TreasureHunt.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: TreasureHunt.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            }) 
            .state('team', {
                url: '/team',
                templateUrl: '/ngApp/views/team.html',
                controller: TreasureHunt.Controllers.TeamController,
                controllerAs: 'controller'
            })
            .state('hunt', {
                url: '/hunt',
                templateUrl: '/ngApp/views/hunt.html',
                controller: TreasureHunt.Controllers.HuntController,
                controllerAs: 'controller'
            })
            .state('huntadd', {
                url: '/huntadd',
                templateUrl: '/ngApp/views/huntadd.html',
                controller: TreasureHunt.Controllers.HuntAddController,
                controllerAs: 'controller'
            })
            .state('huntview', {
                url: '/huntview/:id',
                templateUrl: '/ngApp/views/huntview.html',
                controller: TreasureHunt.Controllers.HuntViewController,
                controllerAs: 'controller'
            })
            .state('huntteams', {
                url: '/huntteams',
                templateUrl: '/ngApp/views/huntteams.html',
                controller: TreasureHunt.Controllers.HuntTeamsController,
                controllerAs: 'controller'
            })
            .state('playpage', {
                url: '/play/:id',
                templateUrl: '/ngApp/views/Play.html',
                controller: TreasureHunt.Controllers.PlayController,
                controllerAs: 'controller'
            })
            .state('riddle', {
                url: '/riddle',
                templateUrl: '/ngApp/views/riddle.html',
                controller: TreasureHunt.Controllers.RiddleController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: TreasureHunt.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('point', {
                url: '/point',
                templateUrl: '/ngApp/views/point.html',
                controller: TreasureHunt.Controllers.PointController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            })
            .state('play', {
                url: '/play',
                templateUrl: '/ngApp/views/Play.html',
                controller: TreasureHunt.Controllers.RiddleController,
                controllerAs: 'controller'
            })

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    
    angular.module('TreasureHunt').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('TreasureHunt').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });

    

}
