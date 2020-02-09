.data
	# Initial input
	buffer: .space 80
	
	# Output Strings
	ys: .asciiz "\nYour string contains "
	tota: .asciiz " characters.\n"
	ta: .asciiz "There are "
	lett: .asciiz " uppercase and lowercase characters.\n"
	digi: .asciiz " digits.\n"
	spac: .asciiz " spaces.\n"
	othe: .asciiz " other characters.\n"
	
.text
main:
	# Prompt user for input in buffer space
	li $v0, 8
	la $a0, buffer
	li $a1, 80
	syscall
	
	# Move input to $t0
	move $t0, $v0
	
	# Initialize Total Count
	li $t1, 0
	
	# Initialize Space Count
	li $t3, 0
	
	# Initialize Number Count
	li $t4, 0
	
	# Initialize Character Count
	li $t5, 0
	
	# Initialize Other Count
	li $t6, 0
	li $t7, 0
	
	
	la $t0, buffer
	lb $t2, 0($t0)
	
	# Jump and Link to length then to output
	jal length
	j output
	
	
length:
	# Check if End of String
	beqz $t2, return
	
	# Sets $a0 to next character
	addi $a0, $a0, 1
	
	# Adds 1 to Total Count
	addi $t1, $t1, 1
	
	# Check if Space
	beq $t2, ' ', cntSpace
	
	# Check if Number
	beq $t2, '0', cntNum
	beq $t2, '1', cntNum
	beq $t2, '2', cntNum
	beq $t2, '3', cntNum
	beq $t2, '4', cntNum
	beq $t2, '5', cntNum
	beq $t2, '6', cntNum
	beq $t2, '7', cntNum
	beq $t2, '8', cntNum
	beq $t2, '9', cntNum
	
	# Check if Lowercase Letter
	beq $t2, 'a', cntChar
	beq $t2, 'b', cntChar
	beq $t2, 'c', cntChar
	beq $t2, 'd', cntChar
	beq $t2, 'e', cntChar
	beq $t2, 'f', cntChar
	beq $t2, 'g', cntChar
	beq $t2, 'h', cntChar
	beq $t2, 'i', cntChar
	beq $t2, 'j', cntChar
	beq $t2, 'k', cntChar
	beq $t2, 'l', cntChar
	beq $t2, 'm', cntChar
	beq $t2, 'n', cntChar
	beq $t2, 'o', cntChar
	beq $t2, 'p', cntChar
	beq $t2, 'q', cntChar
	beq $t2, 'r', cntChar
	beq $t2, 's', cntChar
	beq $t2, 't', cntChar
	beq $t2, 'u', cntChar
	beq $t2, 'v', cntChar
	beq $t2, 'w', cntChar
	beq $t2, 'x', cntChar
	beq $t2, 'y', cntChar
	beq $t2, 'z', cntChar
	
	# Check if Uppercase Letter
	beq $t2, 'A', cntChar
	beq $t2, 'B', cntChar
	beq $t2, 'C', cntChar
	beq $t2, 'D', cntChar
	beq $t2, 'E', cntChar
	beq $t2, 'F', cntChar
	beq $t2, 'G', cntChar
	beq $t2, 'H', cntChar
	beq $t2, 'I', cntChar
	beq $t2, 'J', cntChar
	beq $t2, 'K', cntChar
	beq $t2, 'L', cntChar
	beq $t2, 'M', cntChar
	beq $t2, 'N', cntChar
	beq $t2, 'O', cntChar
	beq $t2, 'P', cntChar
	beq $t2, 'Q', cntChar
	beq $t2, 'R', cntChar
	beq $t2, 'S', cntChar
	beq $t2, 'T', cntChar
	beq $t2, 'U', cntChar
	beq $t2, 'V', cntChar
	beq $t2, 'W', cntChar
	beq $t2, 'X', cntChar
	beq $t2, 'Y', cntChar
	beq $t2, 'Z', cntChar
	
	# Jumps back to top of loop
	j length
	
cntSpace:
	# Adds 1 to Space Counter
	addi $t3, $t3, 1
	j length
	
cntNum:
	# Adds 1 to Number Counter
	addi $t4, $t4, 1
	j length
	
cntChar:
	# Adds 1 to Character Counter
	addi $t5, $t5, 1
	j length
	
return:
	jr $ra
	
output:
	add $t6, $t1, $zero
	sub $t7, $t6, $t3
	sub $t6, $t7, $t4
	sub $t7, $t6, $t5
	
	li $v0, 4
	la $a0, ys
	syscall
	
	li $v0, 1
	move $a0, $t1
	syscall
	
	li $v0, 4
	la $a0, tota
	syscall
	
	la $a0, ta
	syscall
	
	li $v0, 1
	move $a0, $t5
	syscall
	
	li $v0, 4
	la $a0, lett
	syscall
	
	la $a0, ta
	syscall
	
	li $v0, 1
	move $a0, $t4
	syscall
	
	li $v0, 4
	la $a0, digi
	syscall
	
	la $a0, ta
	syscall
	
	li $v0, 1
	move $a0, $t3
	syscall
	
	li $v0, 4
	la $a0, spac
	syscall
	
	la $a0, ta
	syscall
	
	li $v0, 1
	move $a0, $t7
	syscall
	
	li $v0, 4
	la $a0, othe
	syscall

	jr $ra
	