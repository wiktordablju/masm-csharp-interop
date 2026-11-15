.code
MyProc1 proc
add RCX, RDX
;add RCX, R8
;add RCX, R9
;add RCX, [RSP+40] ; RCX,RDX,R8,R9 are passed directly through registers + have 8 bits each reserved on the stack; the fifth and subsequent arguments are passed on the stack
mov RAX, RCX
ret
MyProc1 endp

end