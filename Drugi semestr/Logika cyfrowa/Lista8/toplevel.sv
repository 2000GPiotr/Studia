module PWM_gen(input clk, input [15:0]d, input [1:0]sel,
               output logic [15:0]cnt, cmp, top, output logic out);
  
  always_ff @(posedge clk)begin 
    if(sel==1) cmp <= d;
  else if(sel==2) top <= d;
  end
  
  always_ff @(posedge clk)
  if(sel==3) cnt <= d;
  else if(cnt<top) cnt <= cnt+1;
  else cnt<=0;
 
assign out = cnt < cmp;
endmodule