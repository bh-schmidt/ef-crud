µ
SC:\workspace\ef-crud\src\Business\Caminhoes\AtualizarCaminhoes\AtualizarCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
AtualizarCaminhoes /
{ 
public		 

class		 
AtualizarCaminhao		 "
:		# $
IAtualizarCaminhao		% 7
{

 
private 
readonly 
IUnitOfWork $

unitOfWork% /
;/ 0
private 
readonly 
ICaminhaoRepository ,
caminhaoRepository- ?
;? @
private 
readonly '
IAtualizarCaminhaoValidator 4&
atualizarCaminhaoValidator5 O
;O P
public 
AtualizarCaminhao  
(  !
IUnitOfWork 

unitOfWork "
," #
ICaminhaoRepository 
caminhaoRepository  2
,2 3'
IAtualizarCaminhaoValidator '&
atualizarCaminhaoValidator( B
)B C
{ 	
this 
. 

unitOfWork 
= 

unitOfWork (
;( )
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
this 
. &
atualizarCaminhaoValidator +
=, -&
atualizarCaminhaoValidator. H
;H I
} 	
public 
async 
Task 
< 
Caminhao "
>" #
	Atualizar$ -
(- .
Caminhao. 6
caminhao7 ?
)? @
{ 	
try 
{ 
await 

unitOfWork  
.  !

BeginAsync! +
(+ ,
), -
;- .
var 
	resultado 
= 
await  % 
ProcessarAtualizacao& :
(: ;
caminhao; C
)C D
;D E
if!! 
(!! 
caminhao!! 
.!! 
Valid!! "
)!!" #
{"" 
await## 

unitOfWork## $
.##$ %
CommitAsync##% 0
(##0 1
)##1 2
;##2 3
return$$ 
caminhao$$ #
;$$# $
}%% 
await'' 

unitOfWork''  
.''  !
RollbackAsync''! .
(''. /
)''/ 0
;''0 1
return)) 
	resultado))  
;))  !
}** 
catch++ 
{,, 
await-- 

unitOfWork--  
.--  !
RollbackAsync--! .
(--. /
)--/ 0
;--0 1
throw.. 
;.. 
}// 
}00 	
private22 
async22 
Task22 
<22 
Caminhao22 #
>22# $ 
ProcessarAtualizacao22% 9
(229 :
Caminhao22: B
caminhao22C K
)22K L
{33 	
await44 
caminhao44 
.44 
ValidarAsync44 '
(44' (&
atualizarCaminhaoValidator44( B
)44B C
;44C D
if66 
(66 
caminhao66 
.66 
Valid66 
)66 
await77 
caminhaoRepository77 (
.77( )
AtualizarTudo77) 6
(776 7
caminhao777 ?
)77? @
;77@ A
return99 
caminhao99 
;99 
}:: 	
};; 
}<< Î
\C:\workspace\ef-crud\src\Business\Caminhoes\AtualizarCaminhoes\AtualizarCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
AtualizarCaminhoes /
{ 
public 

class &
AtualizarCaminhaoValidator +
:, -
AbstractValidator. ?
<? @
Caminhao@ H
>H I
,I J'
IAtualizarCaminhaoValidatorK f
{ 
public &
AtualizarCaminhaoValidator )
() *
IValidarModelo		 
validarModelo		 (
,		( )!
IValidarAnoFabricacao

 ! 
validarAnoFabricacao

" 6
,

6 7
IValidarAnoModelo 
validarAnoModelo .
,. /&
IValidarCaminhaoCadastrado &&
caminhaoExistenteValidator' A
)A B
{ 	
RuleFor 
( 
c 
=> 
c 
. 
Id 
) 
. 
NotNull 
( 
) 
. 
WithMessage 
( 
$str ?
)? @
. 
WithErrorCode 
( 
$str =
)= >
;> ?
validarModelo 
. 
AdicionarValidacao ,
(, -
this- 1
)1 2
;2 3 
validarAnoFabricacao  
.  !
AdicionarValidacao! 3
(3 4
this4 8
)8 9
;9 :
validarAnoModelo 
. 
AdicionarValidacao /
(/ 0
this0 4
)4 5
;5 6&
caminhaoExistenteValidator &
.& '
AdicionarValidacao' 9
(9 :
this: >
)> ?
;? @
} 	
} 
} £
TC:\workspace\ef-crud\src\Business\Caminhoes\AtualizarCaminhoes\IAtualizarCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
AtualizarCaminhoes /
{ 
public 

	interface 
IAtualizarCaminhao '
{ 
public 
Task 
< 
Caminhao 
> 
	Atualizar '
(' (
Caminhao( 0
caminhao1 9
)9 :
;: ;
}		 
}

 ∆
]C:\workspace\ef-crud\src\Business\Caminhoes\AtualizarCaminhoes\IAtualizarCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
AtualizarCaminhoes /
{ 
public 

	interface '
IAtualizarCaminhaoValidator 0
:1 2

IValidator3 =
<= >
Caminhao> F
>F G
{ 
} 
}		 «
OC:\workspace\ef-crud\src\Business\Caminhoes\ExcluirCaminhoes\ExcluirCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ExcluirCaminhoes -
{ 
public		 

class		 
ExcluirCaminhao		  
:		! "
IExcluirCaminhao		# 3
{

 
private 
readonly 
IUnitOfWork $

unitOfWork% /
;/ 0
private 
readonly 
ICaminhaoRepository ,
caminhaoRepository- ?
;? @
private 
readonly %
IExcluirCaminhaoValidator 2$
excluirCaminhaoValidator3 K
;K L
public 
ExcluirCaminhao 
( 
IUnitOfWork 

unitOfWork "
," #
ICaminhaoRepository 
caminhaoRepository  2
,2 3%
IExcluirCaminhaoValidator %$
excluirCaminhaoValidator& >
)> ?
{ 	
this 
. 

unitOfWork 
= 

unitOfWork (
;( )
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
this 
. $
excluirCaminhaoValidator )
=* +$
excluirCaminhaoValidator, D
;D E
} 	
public 
async 
Task 
< 
Caminhao "
>" #
Excluir$ +
(+ ,
long, 0
id1 3
)3 4
{ 	
try 
{ 
await 

unitOfWork  
.  !

BeginAsync! +
(+ ,
), -
;- .
var 
caminhao 
= 
await $
ProcessarExclusao% 6
(6 7
id7 9
)9 :
;: ;
if!! 
(!! 
caminhao!! 
.!! 
Valid!! "
)!!" #
{"" 
await## 

unitOfWork## $
.##$ %
CommitAsync##% 0
(##0 1
)##1 2
;##2 3
return$$ 
caminhao$$ #
;$$# $
}%% 
await'' 

unitOfWork''  
.''  !
RollbackAsync''! .
(''. /
)''/ 0
;''0 1
return)) 
caminhao)) 
;))  
}** 
catch++ 
{,, 
await-- 

unitOfWork--  
.--  !
RollbackAsync--! .
(--. /
)--/ 0
;--0 1
throw.. 
;.. 
}// 
}00 	
public22 
async22 
Task22 
<22 
Caminhao22 "
>22" #
ProcessarExclusao22$ 5
(225 6
long226 :
id22; =
)22= >
{33 	
var44 
caminhao44 
=44 
new44 
Caminhao44 '
(44' (
)44( )
{44* +
Id44, .
=44/ 0
id441 3
}444 5
;445 6
await66 
caminhao66 
.66 
ValidarAsync66 '
(66' ($
excluirCaminhaoValidator66( @
)66@ A
;66A B
if88 
(88 
caminhao88 
.88 
Valid88 
)88 
await99 
caminhaoRepository99 (
.99( )
Excluir99) 0
(990 1
caminhao991 9
)999 :
;99: ;
return;; 
caminhao;; 
;;; 
}<< 	
}== 
}>> œ
XC:\workspace\ef-crud\src\Business\Caminhoes\ExcluirCaminhoes\ExcluirCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ExcluirCaminhoes -
{ 
public 

class $
ExcluirCaminhaoValidator )
:* +
AbstractValidator, =
<= >
Caminhao> F
>F G
,G H%
IExcluirCaminhaoValidatorI b
{ 
public $
ExcluirCaminhaoValidator '
(' (&
IValidarCaminhaoCadastrado( B%
validarCaminhaoCadastradoC \
)\ ]
{		 	%
validarCaminhaoCadastrado

 %
.

% &
AdicionarValidacao

& 8
(

8 9
this

9 =
)

= >
;

> ?
} 	
} 
} è
PC:\workspace\ef-crud\src\Business\Caminhoes\ExcluirCaminhoes\IExcluirCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ExcluirCaminhoes -
{ 
public 

	interface 
IExcluirCaminhao %
{ 
public 
Task 
< 
Caminhao 
> 
Excluir %
(% &
long& *
id+ -
)- .
;. /
}		 
}

 æ
YC:\workspace\ef-crud\src\Business\Caminhoes\ExcluirCaminhoes\IExcluirCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ExcluirCaminhoes -
{ 
public 

	interface %
IExcluirCaminhaoValidator .
:/ 0

IValidator1 ;
<; <
Caminhao< D
>D E
{ 
} 
}		 ô
PC:\workspace\ef-crud\src\Business\Caminhoes\InserirCaminhoes\IInserirCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
InserirCaminhoes -
{ 
public 

	interface 
IInserirCaminhao %
{ 
public 
Task 
< 
Caminhao 
> 
Inserir %
(% &
Caminhao& .
caminhao/ 7
)7 8
;8 9
}		 
}

 ë
YC:\workspace\ef-crud\src\Business\Caminhoes\InserirCaminhoes\IInserirCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

	interface %
IInserirCaminhaoValidator .
:/ 0

IValidator1 ;
<; <
Caminhao< D
>D E
{ 
} 
}		 “
OC:\workspace\ef-crud\src\Business\Caminhoes\InserirCaminhoes\InserirCaminhao.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
InserirCaminhoes -
{ 
public		 

class		 
InserirCaminhao		  
:		! "
IInserirCaminhao		# 3
{

 
private 
readonly 
IUnitOfWork $

unitOfWork% /
;/ 0
private 
readonly 
ICaminhaoRepository ,
caminhaoRepository- ?
;? @
private 
readonly %
IInserirCaminhaoValidator 2
caminhaoValidator3 D
;D E
public 
InserirCaminhao 
( 
IUnitOfWork 

unitOfWork "
," #
ICaminhaoRepository 
caminhaoRepository  2
,2 3%
IInserirCaminhaoValidator %
caminhaoValidator& 7
)7 8
{ 	
this 
. 

unitOfWork 
= 

unitOfWork (
;( )
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
this 
. 
caminhaoValidator "
=# $
caminhaoValidator% 6
;6 7
} 	
public 
async 
Task 
< 
Caminhao "
>" #
Inserir$ +
(+ ,
Caminhao, 4
caminhao5 =
)= >
{ 	
try 
{ 
await 

unitOfWork  
.  !

BeginAsync! +
(+ ,
), -
;- .
var 
	resultado 
= 
await  %
ProcessarInsercao& 7
(7 8
caminhao8 @
)@ A
;A B
if!! 
(!! 
caminhao!! 
.!! 
Valid!! "
)!!" #
{"" 
await## 

unitOfWork## $
.##$ %
CommitAsync##% 0
(##0 1
)##1 2
;##2 3
return$$ 
caminhao$$ #
;$$# $
}%% 
await'' 

unitOfWork''  
.''  !
RollbackAsync''! .
(''. /
)''/ 0
;''0 1
return)) 
	resultado))  
;))  !
}** 
catch++ 
{,, 
await-- 

unitOfWork--  
.--  !
RollbackAsync--! .
(--. /
)--/ 0
;--0 1
throw.. 
;.. 
}// 
}00 	
private22 
async22 
Task22 
<22 
Caminhao22 #
>22# $
ProcessarInsercao22% 6
(226 7
Caminhao227 ?
caminhao22@ H
)22H I
{33 	
caminhao44 
.44 
Validar44 
(44 
caminhaoValidator44 .
)44. /
;44/ 0
if66 
(66 
caminhao66 
.66 
Valid66 
)66 
await77 
caminhaoRepository77 (
.77( )
Inserir77) 0
(770 1
caminhao771 9
)779 :
;77: ;
return99 
caminhao99 
;99 
}:: 	
};; 
}<< ∫
XC:\workspace\ef-crud\src\Business\Caminhoes\InserirCaminhoes\InserirCaminhaoValidator.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

class $
InserirCaminhaoValidator )
:* +
AbstractValidator, =
<= >
Caminhao> F
>F G
,G H%
IInserirCaminhaoValidatorI b
{ 
public		 $
InserirCaminhaoValidator		 '
(		' (
IValidarModelo

 
validarModelo

 (
,

( )!
IValidarAnoFabricacao ! 
validarAnoFabricacao" 6
,6 7
IValidarAnoModelo 
validarAnoModelo .
). /
{ 	
RuleFor 
( 
c 
=> 
c 
. 
Id 
) 
. 
Null 
( 
) 
. 
WithMessage 
( 
$str 2
)2 3
. 
WithErrorCode 
( 
$str ;
); <
;< =
validarModelo 
. 
AdicionarValidacao ,
(, -
this- 1
)1 2
;2 3 
validarAnoFabricacao  
.  !
AdicionarValidacao! 3
(3 4
this4 8
)8 9
;9 :
validarAnoModelo 
. 
AdicionarValidacao /
(/ 0
this0 4
)4 5
;5 6
} 	
} 
} ˙
DC:\workspace\ef-crud\src\Business\Caminhoes\IValidarAnoFabricacao.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

	interface !
IValidarAnoFabricacao *
{ 
public 
void 
AdicionarValidacao &
(& '
AbstractValidator' 8
<8 9
Caminhao9 A
>A B
	validatorC L
)L M
;M N
}		 
}

 Ú
@C:\workspace\ef-crud\src\Business\Caminhoes\IValidarAnoModelo.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

	interface 
IValidarAnoModelo &
{ 
public 
void 
AdicionarValidacao &
(& '
AbstractValidator' 8
<8 9
Caminhao9 A
>A B
	validatorC L
)L M
;M N
}		 
}

 Ñ
IC:\workspace\ef-crud\src\Business\Caminhoes\IValidarCaminhaoCadastrado.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

	interface &
IValidarCaminhaoCadastrado /
{ 
public 
void 
AdicionarValidacao &
(& '
AbstractValidator' 8
<8 9
Caminhao9 A
>A B
	validatorC L
)L M
;M N
}		 
}

 Ï
=C:\workspace\ef-crud\src\Business\Caminhoes\IValidarModelo.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

	interface 
IValidarModelo #
{ 
public 
void 
AdicionarValidacao &
(& '
AbstractValidator' 8
<8 9
Caminhao9 A
>A B
	validatorC L
)L M
;M N
}		 
}

 ˛
QC:\workspace\ef-crud\src\Business\Caminhoes\ObterCaminhoes\IObterCaminhaoPorId.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ObterCaminhoes +
{ 
public 

	interface 
IObterCaminhaoPorId (
{ 
Task 
< 
Caminhao 
> 
ObterPor 
(  
long  $
id% '
)' (
;( )
}		 
}

 Ø
TC:\workspace\ef-crud\src\Business\Caminhoes\ObterCaminhoes\IObterTodosOsCaminhoes.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ObterCaminhoes +
{ 
public 

	interface "
IObterTodosOsCaminhoes +
{ 
public		 
Task		 
<		 
IEnumerable		 
<		  
Caminhao		  (
>		( )
>		) *

ObterTodos		+ 5
(		5 6
)		6 7
;		7 8
}

 
} å	
PC:\workspace\ef-crud\src\Business\Caminhoes\ObterCaminhoes\ObterCaminhaoPorId.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ObterCaminhoes +
{ 
public 

class 
ObterCaminhaoPorId #
:$ %
IObterCaminhaoPorId& 9
{		 
private

 
readonly

 
ICaminhaoRepository

 ,
caminhaoRepository

- ?
;

? @
public 
ObterCaminhaoPorId !
(! "
ICaminhaoRepository 
caminhaoRepository  2
)2 3
{ 	
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
} 	
public 
Task 
< 
Caminhao 
> 
ObterPor &
(& '
long' +
id, .
). /
{ 	
return 
caminhaoRepository %
.% &
ObterPor& .
(. /
id/ 1
)1 2
;2 3
} 	
} 
} °	
SC:\workspace\ef-crud\src\Business\Caminhoes\ObterCaminhoes\ObterTodosOsCaminhoes.cs
	namespace 	
Business
 
. 
	Caminhoes 
. 
ObterCaminhoes +
{ 
public		 

class		 !
ObterTodosOsCaminhoes		 &
:		' ("
IObterTodosOsCaminhoes		) ?
{

 
private 
readonly 
ICaminhaoRepository ,
caminhaoRepository- ?
;? @
public !
ObterTodosOsCaminhoes $
($ %
ICaminhaoRepository% 8
caminhaoRepository9 K
)K L
{ 	
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
} 	
public 
Task 
< 
IEnumerable 
<  
Caminhao  (
>( )
>) *

ObterTodos+ 5
(5 6
)6 7
{ 	
return 
caminhaoRepository %
.% &

ObterTodos& 0
(0 1
)1 2
;2 3
} 	
} 
} ”
CC:\workspace\ef-crud\src\Business\Caminhoes\ValidarAnoFabricacao.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

class  
ValidarAnoFabricacao %
:& '!
IValidarAnoFabricacao( =
{ 
public		 
void		 
AdicionarValidacao		 &
(		& '
AbstractValidator		' 8
<		8 9
Caminhao		9 A
>		A B
	validator		C L
)		L M
=>		N P
	validator

 
.

 
RuleFor

 
(

 
c

 
=>

  "
c

# $
.

$ %
AnoFabricacao

% 2
)

2 3
. 
Must 
( 
ano 
=> 
AnoFabricacaoValido 0
(0 1
ano1 4
)4 5
)5 6
. 
WithMessage 
( )
MensagemAnoFabricacaoInvalido :
(: ;
); <
)< =
. 
WithErrorCode 
( 
$str 7
)7 8
;8 9
private 
static 
bool 
AnoFabricacaoValido /
(/ 0
int0 3
ano4 7
)7 8
=>9 ;
ano 
== 
DateTime 
. 
Now 
.  
Year  $
;$ %
private 
static 
string )
MensagemAnoFabricacaoInvalido ;
(; <
)< =
=>> @
$" V
JS√≥ √© poss√≠vel cadastrar um caminh√£o com o ano de fabrica√ß√£o igual a  R
{R S
DateTimeS [
.[ \
Now\ _
._ `
Year` d
}d e
.e f
"f g
;g h
} 
} ˛
?C:\workspace\ef-crud\src\Business\Caminhoes\ValidarAnoModelo.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

class 
ValidarAnoModelo !
:" #
IValidarAnoModelo$ 5
{ 
public		 
void		 
AdicionarValidacao		 &
(		& '
AbstractValidator		' 8
<		8 9
Caminhao		9 A
>		A B
	validator		C L
)		L M
=>		N P
	validator

 
.

 
RuleFor

 
(

 
c

 
=>

  "
c

# $
.

$ %
	AnoModelo

% .
)

. /
. 
Must 
( 
ano 
=> 
AnoModeloValido ,
(, -
ano- 0
)0 1
)1 2
. 
WithMessage 
( %
MensagemAnoModeloInvalido 6
(6 7
)7 8
)8 9
. 
WithErrorCode 
( 
$str 3
)3 4
;4 5
private 
static 
bool 
AnoModeloValido +
(+ ,
int, /
ano0 3
)3 4
=>5 7
ano 
== 
DateTime 
. 
Now 
.  
Year  $
||% '
ano( +
==, .
DateTime/ 7
.7 8
Now8 ;
.; <
Year< @
+A B
$numC D
;D E
private 
static 
string %
MensagemAnoModeloInvalido 7
(7 8
)8 9
=>: <
$" P
DS√≥ √© poss√≠vel cadastrar um caminh√£o com o ano de modelo igual a  N
{N O
DateTimeO W
.W X
NowX [
.[ \
Year\ `
}` a
 ou a e
{e f
DateTimef n
.n o
Nowo r
.r s
Years w
+x y
$numz {
}{ |
.| }
"} ~
;~ 
} 
} ¶
HC:\workspace\ef-crud\src\Business\Caminhoes\ValidarCaminhaoCadastrado.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public		 

class		 %
ValidarCaminhaoCadastrado		 *
:		+ ,
AbstractValidator		- >
<		> ?
Caminhao		? G
>		G H
,		H I&
IValidarCaminhaoCadastrado		J d
{

 
private 
readonly 
ICaminhaoRepository ,
caminhaoRepository- ?
;? @
public %
ValidarCaminhaoCadastrado (
(( )
ICaminhaoRepository) <
caminhaoRepository= O
)O P
{ 	
this 
. 
caminhaoRepository #
=$ %
caminhaoRepository& 8
;8 9
} 	
public 
void 
AdicionarValidacao &
(& '
AbstractValidator' 8
<8 9
Caminhao9 A
>A B
	validatorC L
)L M
{ 	
	validator 
. 
RuleFor 
( 
c 
=>  "
c# $
.$ %
Id% '
)' (
. 
	MustAsync 
( 
( 
id 
, 
ct  "
)" #
=>$ &
CaminhaoExistente' 8
(8 9
id9 ;
); <
)< =
. 
WithMessage 
( 
$str @
)@ A
. 
WithErrorCode 
( 
$str <
)< =
;= >
} 	
private 
async 
Task 
< 
bool 
>  
CaminhaoExistente! 2
(2 3
long3 7
?7 8
id9 ;
); <
{ 	
if 
( 
id 
. 
IsNull 
( 
) 
) 
return 
false 
; 
return 
await 
caminhaoRepository +
.+ ,
IdExistente, 7
(7 8
id8 :
.: ;
Value; @
)@ A
;A B
}   	
}!! 
}"" ‚
<C:\workspace\ef-crud\src\Business\Caminhoes\ValidarModelo.cs
	namespace 	
Business
 
. 
	Caminhoes 
{ 
public 

class 
ValidarModelo 
:  
IValidarModelo! /
{ 
private 
const 
string "
MensagemModeloInvalido 3
=4 5
$str6 L
;L M
public

 
void

 
AdicionarValidacao

 &
(

& '
AbstractValidator

' 8
<

8 9
Caminhao

9 A
>

A B
	validator

C L
)

L M
=>

N P
	validator 
. 
RuleFor 
( 
c 
=>  "
c# $
.$ %
Modelo% +
)+ ,
. 
IsInEnum 
( 
) 
. 
WithMessage 
( "
MensagemModeloInvalido 3
)3 4
. 
WithErrorCode 
( 
$str 0
)0 1
;1 2
} 
} €
3C:\workspace\ef-crud\src\Business\SampleBusiness.cs
	namespace 	
Business
 
{ 
public 

class 
SampleBusiness 
{ 
} 
} 