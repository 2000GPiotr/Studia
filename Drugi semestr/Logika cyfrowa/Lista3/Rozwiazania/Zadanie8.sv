module DCB(input [3:0]i, output a,b,c,d,e,f,g);
  assign a=i[3] | (i[2] & i[0]) | i[1] | (~i[0]&~i[2]);
  assign b=i[3] | ~i[2] | ~i[1]&~i[0] | i[1]&i[0];
  assign c=i[2] | ~i[1] | i[0];
  assign d=~i[2]&~i[1]&~i[0] | i[2]&~i[1]&i[0] | ~i[2]&i[1] | i[1]&~i[0];
  assign e=~i[2]&~i[0] | i[1]&~i[0];
  assign f=~i[1]&~i[0] | i[3]&~i[2] | i[2]&~i[1] | i[2]&~i[0];
  assign g=i[3] | i[2]&~i[1] | ~i[2]&i[1]&i[0] | i[1]&~i[0];
endmodule

