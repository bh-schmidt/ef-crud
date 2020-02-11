»
=C:\workspace\ef-crud\src\Api\Attributes\ExceptionAttribute.cs
	namespace 	
Api
 
. 

Attributes 
{ 
public 

sealed 
class 
ExceptionAttribute *
:+ ,$
ExceptionFilterAttribute- E
{ 
public 
override 
void 
OnException (
(( )
ExceptionContext) 9
context: A
)A B
{		 	
context

 
.

 
Result

 
=

 
new

  
BadRequestResult

! 1
(

1 2
)

2 3
;

3 4
} 	
} 
} ì
:C:\workspace\ef-crud\src\Api\Controllers\BaseController.cs
	namespace 	
Api
 
. 
Controllers 
{ 
[ 
ApiController 
] 
[ 
ExceptionAttribute 
] 
[ 
Route 

(
 
$str 
) 
] 
public		 

abstract		 
class		 
BaseController		 (
:		) *
ControllerBase		+ 9
{

 
	protected 
static 
IActionResult &
CreateResult' 3
(3 4
)4 5
{ 	
return 
new 
OkResult 
(  
)  !
;! "
} 	
	protected 
static 
IActionResult &
CreateObjectResult' 9
(9 :
object: @
valueA F
)F G
{ 	
return 
new 
OkObjectResult %
(% &
value& +
)+ ,
;, -
} 	
} 
} ¦)
IC:\workspace\ef-crud\src\Api\Controllers\Caminhoes\CaminhoesController.cs
	namespace		 	
Api		
 
.		 
Controllers		 
.		 
	Caminhoes		 #
{

 
public 

class 
CaminhoesController $
:% &
BaseController' 5
{ 
private 
readonly "
IObterTodosOsCaminhoes /!
obterTodosOsCaminhoes0 E
;E F
private 
readonly 
IObterCaminhaoPorId ,
obterCaminhaoPorId- ?
;? @
private 
readonly 
IInserirCaminhao )
inserirCaminhao* 9
;9 :
private 
readonly 
IAtualizarCaminhao +
atualizarCaminhao, =
;= >
private 
readonly 
IExcluirCaminhao )
excluirCaminhao* 9
;9 :
public 
CaminhoesController "
(" #"
IObterTodosOsCaminhoes "!
obterTodosOsCaminhoes# 8
,8 9
IObterCaminhaoPorId 
obterCaminhaoPorId  2
,2 3
IInserirCaminhao 
inserirCaminhao ,
,, -
IAtualizarCaminhao 
atualizarCaminhao 0
,0 1
IExcluirCaminhao 
excluirCaminhao ,
), -
{ 	
this 
. !
obterTodosOsCaminhoes &
=' (!
obterTodosOsCaminhoes) >
;> ?
this 
. 
obterCaminhaoPorId #
=$ %
obterCaminhaoPorId& 8
;8 9
this 
. 
inserirCaminhao  
=! "
inserirCaminhao# 2
;2 3
this 
. 
atualizarCaminhao "
=# $
atualizarCaminhao% 6
;6 7
this 
. 
excluirCaminhao  
=! "
excluirCaminhao# 2
;2 3
} 	
[!! 	
HttpGet!!	 
]!! 
public"" 
async"" 
Task"" 
<"" 
IActionResult"" '
>""' (

ObterTodos"") 3
(""3 4
)""4 5
{## 	
var$$ 
	caminhoes$$ 
=$$ 
await$$ !!
obterTodosOsCaminhoes$$" 7
.$$7 8

ObterTodos$$8 B
($$B C
)$$C D
;$$D E
return&& 
CreateObjectResult&& %
(&&% &
	caminhoes&&& /
)&&/ 0
;&&0 1
}'' 	
[)) 	
HttpGet))	 
])) 
[** 	
Route**	 
(** 
$str** 
)** 
]** 
public++ 
async++ 
Task++ 
<++ 
IActionResult++ '
>++' (
ObterPor++) 1
(++1 2
long++2 6
id++7 9
)++9 :
{,, 	
var-- 
caminhao-- 
=-- 
await--  
obterCaminhaoPorId--! 3
.--3 4
ObterPor--4 <
(--< =
id--= ?
)--? @
;--@ A
return// 
CreateObjectResult// %
(//% &
caminhao//& .
)//. /
;/// 0
}00 	
[22 	
HttpPost22	 
]22 
public33 
async33 
Task33 
<33 
IActionResult33 '
>33' (
Inserir33) 0
(330 1
Caminhao331 9
caminhao33: B
)33B C
{44 	
var55 
	resultado55 
=55 
await55 !
inserirCaminhao55" 1
.551 2
Inserir552 9
(559 :
caminhao55: B
)55B C
;55C D
return77 
CreateObjectResult77 %
(77% &
	resultado77& /
)77/ 0
;770 1
}88 	
[:: 	
HttpPut::	 
]:: 
public;; 
async;; 
Task;; 
<;; 
IActionResult;; '
>;;' (
	Atualizar;;) 2
(;;2 3
Caminhao;;3 ;
caminhao;;< D
);;D E
{<< 	
var== 
	resultado== 
=== 
await== !
atualizarCaminhao==" 3
.==3 4
	Atualizar==4 =
(=== >
caminhao==> F
)==F G
;==G H
return?? 
CreateObjectResult?? %
(??% &
	resultado??& /
)??/ 0
;??0 1
}@@ 	
[BB 	

HttpDeleteBB	 
]BB 
[CC 	
RouteCC	 
(CC 
$strCC 
)CC 
]CC 
publicDD 
asyncDD 
TaskDD 
<DD 
IActionResultDD '
>DD' (
ExluirDD) /
(DD/ 0
longDD0 4
idDD5 7
)DD7 8
{EE 	
varFF 
	resultadoFF 
=FF 
awaitFF !
excluirCaminhaoFF" 1
.FF1 2
ExcluirFF2 9
(FF9 :
idFF: <
)FF< =
;FF= >
returnHH 
CreateObjectResultHH %
(HH% &
	resultadoHH& /
)HH/ 0
;HH0 1
}II 	
}JJ 
}KK º
'C:\workspace\ef-crud\src\Api\Program.cs
	namespace 	
Api
 
{ 
public 

static 
class 
Program 
{ 
public		 
static		 
void		 
Main		 
(		  
string		  &
[		& '
]		' (
args		) -
)		- .
{

 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. %
UseServiceProviderFactory *
(* +
new+ .)
AutofacServiceProviderFactory/ L
(L M
)M N
)N O
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} º
'C:\workspace\ef-crud\src\Api\Startup.cs
	namespace 	
Api
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
AppSettings 
. 
	Configure !
(! "
configuration" /
)/ 0
;0 1
} 	
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. $
AddEntityFrameworkSqlite -
(- .
). /
. 
AddDbContext 
< 
EfCrudContext +
>+ ,
(, -
)- .
;. /
services 
. 
AddControllers #
(# $
)$ %
;% &
} 	
public 
void 
ConfigureContainer &
(& '
ContainerBuilder' 7
builder8 ?
)? @
{ 	"
ContainerConfiguration "
." #
	Configure# ,
(, -
builder- 4
)4 5
;5 6
} 	
public!! 
void!! 
	Configure!! 
(!! 
IApplicationBuilder!! 1
app!!2 5
,!!5 6
IWebHostEnvironment!!7 J
env!!K N
)!!N O
{"" 	
if## 
(## 
env## 
.## 
IsDevelopment## !
(##! "
)##" #
)### $
{$$ 
app%% 
.%% %
UseDeveloperExceptionPage%% -
(%%- .
)%%. /
;%%/ 0
}&& 
app(( 
.(( 

UseRouting(( 
((( 
)(( 
;(( 
app** 
.** 
UseEndpoints** 
(** 
	endpoints** &
=>**' )
{++ 
	endpoints,, 
.,, 
MapControllers,, (
(,,( )
),,) *
;,,* +
}-- 
)-- 
;-- 
ConfigureContext// 
.// 
	Configure// &
(//& '
)//' (
;//( )
}00 	
}11 
}22 