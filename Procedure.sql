create procedure [dbo].[SpAddEmployeeDetails]
(
@id varchar (255),
@name varchar(255),
@phone varchar(255),
@address varchar(255),
@Department varchar(255),
@Gender varchar(255),
@basic_pay float,
@deductions float,
@taxable_pay float,
@tax float,
@net_pay float,
@start Date
)
as
begin
insert into employee_payroll values
(
@id,@name,@basic_pay,@start,@Gender,@phone,@Address,@Department,@Deductions,@taxable_pay,@net_pay,@Tax
)
end
SELECT id,name,address,Department,Gender,basic_pay,deductions,
                                    taxable_pay,tax,net_pay
                                    From employee_payroll
select * from employee_payroll

use payroll_service
select * from employee_payroll

select * from employee_payroll where start between '2018-01-01' and GETDATE()

select * from employee_payroll where start between '2018-01-01' and '2021-05-22'