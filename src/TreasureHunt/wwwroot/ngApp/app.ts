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
            .state('huntteams', {
                url: '/huntteams',
                templateUrl: '/ngApp/views/huntteams.html',
                controller: TreasureHunt.Controllers.HuntTeamsController,
                controllerAs: 'controller'
            })
            .state('riddle', {
                url: '/riddle',
                templateUrl: '/ngApp/views/riddle.html',
                controller: TreasureHunt.Controllers.RiddleController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    

}
