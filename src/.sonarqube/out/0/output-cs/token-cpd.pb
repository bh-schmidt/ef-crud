�
,C:\workspace\ef-crud\src\Models\BaseModel.cs
	namespace 	
Models
 
{ 
public 

abstract 
class 
	BaseModel #
{ 
public		 
long		 
?		 
Id		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
public

 
ValidationResult

 
?

  
ValidationResult

! 1
{

2 3
get

4 7
;

7 8
set

9 <
;

< =
}

> ?
public 
bool 
Valid 
=> 
ValidationResult -
?- .
.. /
IsValid/ 6
??7 9
false: ?
;? @
public
void
Validar
<
TModel
>
(

IValidator
<
TModel
>
	validator
)
where
TModel
:
	BaseModel
=>
ValidationResult 
= 
	validator (
.( )
Validate) 1
(1 2
(2 3
TModel3 9
)9 :
this: >
)> ?
;? @
public 
async 
Task 
ValidarAsync &
<& '
TModel' -
>- .
(. /

IValidator/ 9
<9 :
TModel: @
>@ A
	validatorB K
)K L
whereM R
TModelS Y
:Z [
	BaseModel\ e
=>f h
ValidationResult 
= 
await $
	validator% .
.. /

(< =
(= >
TModel> D
)D E
thisE I
)I J
;J K
} 
} �
5C:\workspace\ef-crud\src\Models\Caminhoes\Caminhao.cs
	namespace 	
Models
 
. 
	Caminhoes 
{ 
public 

class 
Caminhao 
: 
	BaseModel %
{ 
public 
ModeloCaminhao 
Modelo $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
int 

{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
int		 
	AnoModelo		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
}

 
} �
;C:\workspace\ef-crud\src\Models\Caminhoes\ModeloCaminhao.cs
	namespace 	
Models
 
. 
	Caminhoes 
{ 
public 

enum 
ModeloCaminhao 
:  
byte! %
{ 
FH 

= 
$num
, 
FM 

= 
$num
} 
} 