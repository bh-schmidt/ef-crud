�
4C:\workspace\ef-crud\src\SystemConfig\AppSettings.cs
	namespace 	
SystemConfig
 
{ 
public 

static 
class 
AppSettings #
{ 
public 
static 
string 
? 
SqliteConnection .
{/ 0
get1 4
;4 5
private6 =
set> A
;A B
}C D
public		 
static		 
void		 
	Configure		 $
(		$ %
IConfiguration		% 3

)		A B
{

 	
SqliteConnection 
= 

., -
GetConnectionString- @
(@ A
$strA I
)I J
;J K
} 	
}
} 