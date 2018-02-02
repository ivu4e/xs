﻿grammar Coral;

program : statement+;

//stats : (statement ';')* ; // match zero or more ';'-terminatedstatements

//exprList : expr (',' expr)* ;

statement :exportStatement;		  

printStatement:'print' '(' Text ')' Terminate;

// 导出命名空间
exportStatement:Export nameSpace BlockLeft (exportSupportStatement)* BlockRight Terminate;
// 导出命名空间支持的语句
exportSupportStatement:
importStatement
|packageStatement
|functionMainStatement
;
// 导入命名空间
importStatement:Import BlockLeft (nameSpaceStatement)* BlockRight Terminate;
// 主函数
functionMainStatement:Main Define Function BlockLeft (functionSupportStatement)* BlockRight Terminate;
// 定义包
packageStatement:id Define Package (Wave parameterClauseIn)? BlockLeft (packageSupportStatement)* BlockRight Terminate;
// 包支持的语句
packageSupportStatement:
packageStatement
|packageInvariableStatement
|packageInitStatement
|functionStatement
;
// 包构造方法
packageInitStatement:SelfSub Define Function BlockLeft (functionSupportStatement)* BlockRight Terminate;
// 定义不变量
packageInvariableStatement:expression Define expression Terminate;
// 函数
functionStatement:id Define Function parameterClauseIn Wave parameterClauseOut BlockLeft (functionSupportStatement)* BlockRight Terminate;
// 返回
returnStatement: ArrowRight expressionList Terminate;
// 入参
parameterClauseIn : '(' parameter? (',' parameter)*  ')'  ;
// 出参
parameterClauseOut : '(' parameter? (',' parameter)*  ')'  ;
// 参数结构
parameter : id ':' basicType;
// 函数支持的语句
functionSupportStatement:
 returnStatement
| invariableStatement
| printStatement
| judgeWithElseStatement
| judgeStatement
| loopStatement
| loopInfiniteStatement
| printStatement
| assignStatement
| expressionStatement
;

logicStatement:
 returnStatement
| invariableStatement
| printStatement
| judgeWithElseStatement
| judgeStatement
| loopStatement
| loopInfiniteStatement
| loopJumpStatement
| printStatement
| assignStatement
| expressionStatement
;
// 有else的判断
judgeWithElseStatement:judgeBaseStatement JudgeSub BlockLeft (logicStatement)* BlockRight Terminate;
// 判断
judgeStatement:judgeBaseStatement Terminate;
// 判断基础
judgeBaseStatement:Judge expression BlockLeft (logicStatement)* BlockRight;
// 循环
loopStatement:Loop iteratorStatement Wave id BlockLeft (logicStatement)* BlockRight Terminate;
// 无限循环
loopInfiniteStatement:Loop BlockLeft (logicStatement)* BlockRight Terminate;
// 跳出循环
loopJumpStatement:LoopSub Terminate;
// 迭代器
iteratorStatement:Number '..' Number '..' Number | Number '..' Number;
// 命名空间
nameSpaceStatement:nameSpace Terminate;

// 定义不变量
invariableStatement:expression Define expression Terminate;
// 赋值
assignStatement: expression '=' expression Terminate;

expressionStatement: expression Terminate;

// 基础表达式
primaryExpression: 
id
| t=Self
| dataStatement
| '(' expression ')'
;

// 表达式
expression:
primaryExpression
| id tuple // 函数调用
| nameSpace wave tuple
| expressionList // 表达式列表
| expression call expression // 链式调用
| expression judge expression // 判断型表达式
| expression add expression // 和型表达式
| expression mul expression // 积型表达式
;

expressionList : '(' (expression (',' expression)*)? ')'; // 参数列表

tuple : '(' (id ':' expression (',' id ':' expression)* )? ')'; // 元组

nameSpace:id ('.'id)* ;

// 基础数据
dataStatement:
t=Number
| t=Text
| t=True
| t=False
;
// 基础类型名
basicType:
t=TypeNumber
| t=TypeText
| t=TypeBool
;

// bool值
bool:t=True|t=False;

judge : op=('||' | '&&' | '==' | '!=' | '<' | '>');
add : op=('+' | '-');
mul : op=('*' | '/');
call : op='.';
wave : op='~';

id: op=(IDPublic|IDPrivate);

Terminate : ';';

BlockLeft : '{';
BlockRight : '}';

Define : '=>';
Redefine: '<=';

Import : '<:';
Export : ':>';

SelfSub : '~^';
Self : '^';

ArrowRight : '->';
ArrowLeft : '<-';

JudgeSub : '~?';
Judge : '?';

LoopSub : '~@';
Loop : '@';

ExcptionSub : '~!';
Excption : '!';

FunctionSub : '~$';
Function : '$';

PackageSub : '~#';
Package : '#';

ProtocolSub : '~|';
Protocol : '|';

Wave : '~';

TypeNumber: 'number';
TypeText: 'text';
TypeBool: 'bool';
True: 'true';
False: 'false';

Main: 'Main';

Number :DIGIT+ ('.' DIGIT+)?; // 数字
fragment DIGIT : [0-9] ;             // 单个数字
Text: '"' (~[\\\r\n])*? '"'; //文本
IDPrivate : '_' [a-zA-Z0-9]*; // 私有标识符
IDPublic  : [a-zA-Z] [a-zA-Z0-9]*; // 公有标识符

Comment : '/*' .*? '*/' -> skip; // 结构注释
CommentLine : '//' .*? '\r'? '\n' -> skip; // 行注释

//WS : ' ' -> skip;

WS   : [ \t\r\n]+ -> skip; // 空白， 后面的->skip表示antlr4在分析语言的文本时，符合这个规则的词法将被无视