# Matthew Young
# IT 320 Lab Assignment 1
# I certify that this program is entirely my own creation.
# I have not shared this code with any other person.
# Step 1: Create preset strings for printing prompts and results
# Step 2: Create prompts using string displays and move inputs into registers as int
# Step 3: Check if prompt b is less than or equal to prompt a, if it is, display error notification, if not, continue
# Step 4: Initialize Counter, Average, and Sum registers ($t3, $t5, $t6)
# Step 5: Run calculations for sum and counter in first while loop
# Step 6: Compute average in "segment"
# Step 7: Print the beginning string and first value of generated numbers 
# Step 8: Print the remaining generated numbers in a while loop
# Step 9: Display the error notification that b <= a
# Step 10: Print the appropriate string and output for total generated numbers and average of generated numbers
# Step 11: Return to operating system


.data
	# Preset strings used in prints
	prompta: .asciiz "Enter the Starting Number: "
	promptb: .asciiz "Enter the Ending Number: "
	promptc: .asciiz "Enter the increment value: "
	none: .asciiz "B <= A, No Numbers Printed"
	comma: .asciiz ", "
	print1: .asciiz "The generated numbers are: "
	print2: .asciiz "\nThe total generated numbers: "
	print3: .asciiz "\nAverage of the generated numbers: "
.text
main:
	# prompt user for A
	li $v0, 4
	la $a0, prompta
	syscall
	li $v0, 5
	syscall
	move $t0, $v0
	move $t4, $v0

	# prompt user for B
	li $v0, 4
	la $a0, promptb
	syscall
	li $v0, 5
	syscall
	move $t1, $v0

	# prompt user for C
	li $v0, 4
	la $a0, promptc
	syscall
	li $v0, 5
	syscall
	move $t2, $v0
	
	# Check for b<=a
	ble $t1, $t0, noNum

	# Initialize Counter
	li $t3, 0

	# Clear register for later
	addi $t5, $zero, 0

	# Running Total
	addi $t6, $zero, 0
loop1:
	# While loop to compute total generated numbers ($t3) and number sum ($t6)
	bge $t4, $t1, segment
	addi $t3, $t3, 1
	add $t6, $t6, $t4
	add $t4, $t4, $t2
	j loop1
segment:
	# Computes Average of Generated Numbers ($t5)
	div $t5, $t6, $t3

	# Resets $t4
	addi $t4, $zero, 0
	add $t4, $t4, $t0

	# Prints "The generated numbers are: "
	li $v0, 4
	la $a0, print1
	syscall

	# Prints first value
	li $v0, 1
	move $a0, $t4
	syscall
	add $t4, $t4, $t2
loop2:
	# Prints each value with a comma and space before each
	bge $t4, $t1, end
	li $v0, 4
	la $a0, comma
	syscall
	li $v0, 1
	move $a0, $t4
	syscall
	add $t4, $t4, $t2
	j loop2
noNum:
	# Prints error message if b<=a
	li $v0, 4
	la $a0, none
	syscall
end:
	# Prints end results for total generated numbers ($t3) and average of the generated numbers ($t5)
	li $v0, 4
	la $a0, print2
	syscall

	li $v0, 1
	move $a0, $t3
	syscall
	
	li $v0, 4
	la $a0, print3
	syscall
	
	li $v0, 1
	move $a0, $t5
	syscall

	# Return to operating system
	jr $ra