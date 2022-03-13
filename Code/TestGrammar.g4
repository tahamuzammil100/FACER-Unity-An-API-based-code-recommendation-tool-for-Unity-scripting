grammar TestGrammar;
//file: assignment | EOF;
/*
file: assignment* | EOF;
assignment: Identifier Equals Number Newline;

Number: [0-9]+;
Newline: ('\r' '\n'? | '\n')  ;
Identifier: [a-zA-Z_][a-zA-Z0-9_]*;
Equals: '=';
Whitespace: [ \t]+ -> skip;
*/
common_member_declaration:VOID method_declaration;
method_declaration // lamdas from C# 6
	: method_member_name type_parameter_list? OPEN_PARENS formal_parameter_list? CLOSE_PARENS
	    type_parameter_constraints_clauses? (method_body | right_arrow throwable_expression ';')
	;
method_member_name
	: (identifier | identifier '::' identifier) (type_argument_list? '.' identifier)*
	;
type_parameter_list
	: '<' type_parameter (','  type_parameter)* '>'
	;
