"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var worker_1 = require("./worker");
var AddWorkersComponent = /** @class */ (function () {
    function AddWorkersComponent(_enrollmentService) {
        this._enrollmentService = _enrollmentService;
        this.jobs = ['Jefe', 'Secretaria', 'Junior', 'Camarero'];
        this.workerModel = new worker_1.worker("", "", "", 0);
    }
    AddWorkersComponent.prototype.onSubmit = function () {
        this._enrollmentService.enroll(this.workerModel)
            .subscribe(function (data) { return console.log('Success!!', data); }, function (error) { return console.log('Error!!', error); });
    };
    AddWorkersComponent = __decorate([
        core_1.Component({
            selector: 'app-add-workers',
            templateUrl: './add-workers.component.html'
        })
    ], AddWorkersComponent);
    return AddWorkersComponent;
}());
exports.AddWorkersComponent = AddWorkersComponent;
//# sourceMappingURL=add-workers.component.js.map