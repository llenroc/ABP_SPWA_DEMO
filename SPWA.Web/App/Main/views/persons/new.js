(function () {
    angular.module('app').controller('spwa.views.person.new', [
        '$scope', '$modalInstance', 'abp.services.app.person',
        function ($scope, $modalInstance, personService) {

            alert('123');
            var vm = this;
            vm.personDto = {};

            vm.save = function () {
                alert('789');
                personService.addPerson(vm.personDto)
                    .success(function () {
                        abp.notify.info('保存成功!');
                        $modalInstance.close();
                    });
            };

            vm.cancel = function () {
                alert('456');
                $modalInstance.dismiss();
            };
        }
    ]);
})();