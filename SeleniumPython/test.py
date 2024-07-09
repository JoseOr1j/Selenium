class Book:
  def __init__(self, name, author):
    # class var has to be in function 
    self.name = name
    self.author = author 

# main function 
def __main__():
  book1 = Book("Harry Potter", "J.K. Rowling")
  book2 = Book("Lord of the Rings", "J.R.R. Tolkien")

  print(book1.name)
  print(book1.author)
  print(book2.name)
  print(book2.author)

book2 = Book("KyleBook", "JoseAuthor")

print(book2.name)


class Hero:
  def __init__(self, name, health):
    self.name = name
    self.health = health

DVA = Hero("D.va", 100)
Orisa = Hero("Orisa", 200)
Mercy = Hero("D.va", 200)

class CosmeticSkin:
  def __init__(self, name, price):
    self.name = name
    self.price = price 

DVA = CosmeticSkin("BlueSky", "14.99")
Mercy = CosmeticSkin("Pink", "19.99")

print("Cosmetic choice is: ", DVA.name)
print("Comesetic choice price is: ", Mercy.price)

class updateBuff:
  def __init__(self, version):
    self.version = version 

DVA = updateBuff("1.0")
Mercy = updateBuff("1.1")

print("Version update is: ", DVA.version)

class Ranked:
  def __init__(self, name):
    self.name = "Reward for: " + name
DVA = Ranked("Season 12")
Mercy = Ranked("Season 13")
Ana = Ranked("Season 14")

print("Ana got this: ", Ana.name)
print("Mercy got this", Mercy.name)

class Youtube:
  def __init__(self, name):
    self.name = name

Zuck = Youtube("Zuck")
print(Zuck)


#inheritance 

class Dva:
  def greet(self):
    return "Hiya Dva"

class Mercy(Dva):
  def greetDva(self):
    return self.greet() + " Mercy"

instanceMercy = Mercy()

print(instanceMercy.greetDva())

class Orisa:
  def attack(self):
    return "Orisa attacks"

class Reaper(Orisa):
  def defends(self):
    return self.attack() + " Reaper"

instanceReaper = Reaper()

print(instanceReaper.defends())


title = "The Great Gatsby"
title2 = "The Last of Us"
combinedTitle = title + title2

if (combinedTitle != "Book1Book2"):
  print("Book Title is wrong")




