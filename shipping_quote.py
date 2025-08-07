# Shipping Quote Console Application

# Display welcome message
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt the user to enter the package weight
weight = float(input("Please enter the package weight: "))

# Check if the package is too heavy
if weight > 50:
    print("Package too heavy to be shipped via Package Express. Have a good day.")
    exit()

# Prompt the user to enter the package width
width = float(input("Please enter the package width: "))

# Prompt the user to enter the package height
height = float(input("Please enter the package height: "))

# Prompt the user to enter the package length
length = float(input("Please enter the package length: "))

# Check if the package is too large (sum of dimensions > 50)
if (width + height + length) > 50:
    print("Package too big to be shipped via Package Express.")
    exit()

# Calculate the shipping quote
quote = (width * height * length * weight) / 100

# Display the result to the user
print(f"Your estimated total for shipping this package is: ${quote:.2f}")
print("Thank you!")
