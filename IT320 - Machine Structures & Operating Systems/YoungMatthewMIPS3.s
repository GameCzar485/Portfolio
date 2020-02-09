# Matthew Young
# IT 320
# I certify that this program is entirely my own creation.
# I have not shared this code with any other person.
# Code in Python:
# def fibonacci():
#     n = int(input(print("Which Fibonacci number do you want? ")))
#     a = 0
#     b = 1
#     d = 47
#     e = 46
#     if n < d:
#         for i in range(1, n):
#             c = a
#             a = b
#             if i != e:
#                 b = b + c
#             else:
#                 break
#         n = str(n)
#         b = str(b)
# 
#         print("Fibonacci # " + n + " is " + b)
#     else:
#         print("ERROR: Answer does not fit in 32 bits")
# 
# fibonacci()
.data      
	# set ouput strings
	p1: .asciiz "Which Fibonacci number do you want? " 
	p2: .asciiz "Fibonacci # " 
	p3: .asciiz " is "     
	e1: .asciiz "ERROR: Answer does not fit in 32 bits"
.text            
.globl main
main: 
	# print the prompt
	li $v0, 4     
	la $a0, p1      
	syscall
	
	# store input value
	li $v0, 5     
	syscall         
	move $t0, $v0 

	# initialize value stores($t1, $t2, $t3) for later
	move $t1, $zero      
	li $t2, 1           
	move $t3, $zero
	
	# initialize error limit
	li $t5, 47           
	
	# jump to error if input value is larger than 46
	bge $t0, $t5, error   
	
	# initialize checker for exception
	li $t6, 45
	
loop:
	# for loop for i <= input value
	bge $t3, $t0, done
	move $t4, $t1    
	move $t1, $t2
	
	# skip next line if counter is at 45
	bge $t3, $t6, eloop
	add $t2, $t2, $t4
	
eloop:
	# counter adds 1
	addi $t3, $t3, 1        

	# reiterates loop
	b loop
error:
	# print error message
	li $v0, 4
	la $a0, e1
	syscall
	
	# return to system
	jr $ra               
done:
	# print "Fibonacci # "
	li $v0, 4
	la $a0, p2
	syscall
	
	# print the input value number($t3)
	li $v0, 1
	move $a0, $t3
	syscall
	
	# print " is "
	li $v0, 4
	la $a0, p3
	syscall
	
	# print the fibonacci factorial number ($t1)
	li $v0, 1
	move $a0, $t1
	syscall
	
	# return to system
	jr $ra