(function () {
    var app = angular.module('app');

    var controllerId = 'spwa.views.persons.index';
    app.controller(controllerId, [
        '$scope', 'abp.services.app.person',
        function ($scope, personService) {
            var vm = this;

           // vm.localize = abp.localization.getSource('Source');

            vm.persons = [];


            function getPersons() {
                personService.getPersons().success(function (data) {vm.persons = data.persons;})
            };           
            getPersons();

            vm.getPersonCountText = function () {
                return abp.utils.formatString(App.localize('Xpersons'), vm.persons.length);
            };
        }
    ]);
})();