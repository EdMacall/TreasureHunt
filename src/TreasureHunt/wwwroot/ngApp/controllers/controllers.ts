namespace TreasureHunt.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }


    export class TeamController {
        public message = 'Hello from the Team page!';

        public teams;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/teams')
                .then((response) => { this.teams = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntController {
        public message = 'Hello from the Hunt page!';

        public hunts;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class HuntTeamsController {
        public message = 'Hello from the Hunt Teams page!';

        public hunts;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/hunts')
                .then((response) => { this.hunts = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }


    export class RiddleController {
        public message = 'Hello from the Riddle page!';

        public riddles;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/riddles')
                .then((response) => { this.riddles = response.data })
                .catch((response) => { console.log('Whitney Houston,  we have a problem...') })
        }
    }

}
