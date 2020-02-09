.data
	# initialize data stores
	task2: .space 80
	dacca: .asciiz "Last Name: Young  First Name: Matthew\n"
	prompt: .asciiz "Enter a String: "
	count: .asciiz "\nCount of upper case letters: "
	
.text
main:
	# Display name
	li $v0, 4
	la $a0, dacca
	syscall
	
	# Display prompt
	li $v0, 4
	la $a0, prompt
	syscall
	
	# Get user input
	li $v0, 8
	la $a0, task2
	li $a1, 80
	syscall
	
	# Move input to $t0
	move $t0, $v0
	
	# Initialize upper case counter
	li $t1, 0
	
loop:
	# sets current letter
	lb $t2, 0($t0)
	
	# checks for end of string
	beq $t2, 0x0, return
	
	# checks for capital letter
	beq $t2, 'A', cnt
	beq $t2, 'B', cnt
	beq $t2, 'C', cnt
	beq $t2, 'D', cnt
	beq $t2, 'E', cnt
	beq $t2, 'F', cnt
	beq $t2, 'G', cnt
	beq $t2, 'H', cnt
	beq $t2, 'I', cnt
	beq $t2, 'J', cnt
	beq $t2, 'K', cnt
	beq $t2, 'L', cnt
	beq $t2, 'M', cnt
	beq $t2, 'N', cnt
	beq $t2, 'O', cnt
	beq $t2, 'P', cnt
	beq $t2, 'Q', cnt
	beq $t2, 'R', cnt
	beq $t2, 'S', cnt
	beq $t2, 'T', cnt
	beq $t2, 'U', cnt
	beq $t2, 'V', cnt
	beq $t2, 'W', cnt
	beq $t2, 'X', cnt
	beq $t2, 'Y', cnt
	beq $t2, 'Z', cnt
	
	# Moves to next letter
	addi $t0, $t0, 1
	j loop
cnt:
	# Adds to the count and moves to next letter
	addi $t1, $t1, 1
	addi $t0, $t0, 1
	j loop
return:
	# Print the Count statement
	li $v0, 4
	la $a0, count
	syscall
	
	# Print the current upper case counter
	li $v0, 1
	move $a0, $t1
	syscall
	
	jr $ra
	