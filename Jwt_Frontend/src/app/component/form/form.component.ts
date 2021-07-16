import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, NumberValueAccessor, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Departments } from 'src/app/Models/departments';
import { Designation } from 'src/app/Models/designation';
import { User } from 'src/app/Models/user';
import { FormService } from 'src/app/service/form.service';
import { UserService } from 'src/app/service/user.service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  // userModel = new User;
  formGroup: FormGroup;
  user: User = new User;

  departments: Departments[];
  design : Designation[];
  

  constructor(private userService: UserService,
    private formService: FormService,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router : Router) { }

  


  // saveUser() {
  //   this.userService.createUser(this.user).subscribe(data => {
  //     console.log(data);
  //     alert("User added successfully");
  //   },
  //     error => console.log(error));
  // }

  saveUser() {
    this.userService.createUser(this.user).subscribe(
        (resp) => {
            console.log(resp);
          this.router.navigate(["/login"]);
        },
        (error) => {
            console.log(error.error);
        }
    );
}

  // goToForm(){

  // this.router.navigate(['users']);
  // }

  ngOnInit(): void {

    this.getDepartment();
    this.getDesignations(this.route.snapshot.paramMap.get('id'));
   

  }
  getDepartment(){
    this.formService.getDepartments().subscribe(data => {
      this.departments = data;
      console.log(data);
    },
    error => {
      console.log(error);
    });
  }
  getDesignations(id){
    if (id == null || id == undefined){
      id = 1;
    }
    console.log(id);
    this.formService.getDesignations(id).subscribe( data => {
      this.design = data;
      console.log(data);
    },
    error => {
      console.log(error);
    });
  }

  // getDesignations(formGroupName: string) {

  //   const formGroup = this.formGroup.get(formGroupName);

  //   const departmentCode = formGroup.value.Departments.code;
  //   const departmentName = formGroup.value.Departments.name;

  //   console.log(`${formGroupName} Departments code: ${departmentCode}`);
  //   console.log(`${formGroupName} Departments name: ${departmentName}`);

  //   this.formService.getDesignations(departmentCode).subscribe(
  //     data => {

  //       if (formGroupName === 'Designation') {
  //         this.designation = data;
  //       }

  //       // select first item by default
  //       formGroup.get('designation').setValue(data[0]);
  //     }
  //   );
  // }

  onFormSubmit() {
    console.log(this.user);
    this.saveUser();
  }
  resetForm(userForm:NgForm){
    userForm.resetForm();
  }

}
