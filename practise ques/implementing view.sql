select * from Students
--view with encryption

create view v1
with encryption
as
select studentRollNumber, studentname,class from students

--view with checkoption
create view v2
as
select StudentRollNumber, studentname from students
where StudentName = 'syeda'
with check option


--view with schemabinding

create view v3
with schemabinding  --u cannot drop table now 
as
select StudentRollNumber, studentname from dbo.students

--listing dependencies
sp_helptext  v1    --shows the original query (how view created)
sp_depends v1  -- shows all depedencies




--create view, which uses all three check keyword in a single view
create view v4
with encryption, schemabinding
as
select studentRollNumber, studentname, class
from dbo.Students
where StudentName = 'syeda'
with check option

-- i want u to create a view which will find who's studentname contains _


CREATE VIEW v5
AS
SELECT StudentRollNumber, StudentName
FROM dbo.Students
WHERE StudentName LIKE '%[_]%';

select * from v5
 