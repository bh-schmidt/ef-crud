�
6C:\workspace\ef-crud\src\IoC\ContainerConfiguration.cs
	namespace 	
IoC
 
{ 
public		 

static		 
class		 "
ContainerConfiguration		 .
{

 
public 
static 
void 
	Configure $
($ %
ContainerBuilder% 5
builder6 =
)= >
{ 	
var
businessAssembly
=
Assembly
.
GetAssembly
(
typeof
(
SampleBusiness
)
)
;
var 
dataAssembly 
= 
Assembly '
.' (
GetAssembly( 3
(3 4
typeof4 :
(: ;

SampleData; E
)E F
)F G
;G H
Register 
( 
builder 
, 
businessAssembly .
!. /
)/ 0
;0 1
Register 
( 
builder 
, 
dataAssembly *
!* +
)+ ,
;, -
} 	
private 
static 
void 
Register $
($ %
ContainerBuilder% 5
builder6 =
,= >
Assembly? G
assemblyH P
)P Q
{ 	
builder 
. !
RegisterAssemblyTypes )
() *
assembly* 2
)2 3
. 
Where 
( 
a 
=> 
a 
. 
IsClass 
&&  
! 
a 
. 

IsAbstract !
)! "
. 
As 
( 
a 
=> 
a 
. 

(# $
)$ %
. 
Where 
( 
i 
=> 
i 
. 
IsInterface %
&&& (
i 
. 
Name 
== !
$"" $
I$ %
{% &
a& '
.' (
Name( ,
}, -
"- .
). /
)/ 0
. $
InstancePerLifetimeScope )
() *
)* +
;+ ,
}   	
}!! 
}"" 