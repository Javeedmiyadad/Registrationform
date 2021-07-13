import { Departments } from "./departments";
import { Designation } from "./designation";

export class User {

    public firstName: string;
    public lastName: string;
    public Doj: string;
    public Age: number;
    public departmentsid: number;
    public designationdesId: number;
    public departments:Departments;
    public designation:Designation;
    constructor(
    ) { }
}
