.code

CheckMMX proc
    push rbx
    mov eax, 1
    cpuid
    shr edx, 23
    and edx, 1
    mov eax, edx
    pop rbx
    ret
CheckMMX endp

CheckSSE proc
    push rbx
    mov eax, 1
    cpuid
    shr edx, 25
    and edx, 1
    mov eax, edx
    pop rbx
    ret
CheckSSE endp

CheckSSE2 proc
    push rbx
    mov eax, 1
    cpuid
    shr edx, 26
    and edx, 1
    mov eax, edx
    pop rbx
    ret
CheckSSE2 endp

CheckSSE3 proc
    push rbx
    mov eax, 1
    cpuid
    and ecx, 1
    mov eax, ecx
    pop rbx
    ret
CheckSSE3 endp

; OPERATIONS

my_SUB proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    psubb  xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_SUB endp


my_AND proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    pand   xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_AND endp


my_OR proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    por    xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_OR endp


my_XOR proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    pxor   xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_XOR endp

my_MAX proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    pmaxub xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_MAX endp

my_AVG proc
    movdqu xmm0, [rcx]
    movdqu xmm1, [rdx]
    pavgb  xmm0, xmm1
    movdqu [r8], xmm0
    ret
my_AVG endp

end