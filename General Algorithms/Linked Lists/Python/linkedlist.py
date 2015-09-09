class Node:
	
	def __init__(self, data):
		self.value = data;
		self.Next = None;
	
	def addToEnd(self, data):
		if(self.Next == None):
			self.Next = Node(data);
		else:
			self.Next.addToEnd(data);
	
	def addSorted(self, data):
		if(self.Next == None):
			self.Next = Node(data);
		elif(data < self.Next.value):
			temp = Node(data);
			temp.Next = self.Next;
			self.Next = temp;
		else:
			self.Next.addSorted(data);
			
	def find(self, data, index):
		if(self.value == data):
			print "The Index is at: " + str(index);
			return;
		
		if(self.Next == None):
			print "Could not find it";
		
		index += 1;
		self.Next.find(data, index);
	
	def minItem(self, minValue):
		if(self.value < minValue):
			minValue = self.value;
		
		if(self.Next == None):
			print "The minimum value is: " + str(minValue);
		else:
			self.Next.minItem(minValue);
	
	def maxItem(self, maxValue):
		if(self.value > maxValue):
			maxValue = self.value;
		
		if(self.Next == None):
			print "The maximum value is: " + str(maxValue);
		else:
			self.Next.maxItem(maxValue);			
	
	def printList(self):
		print str(self.value) + " => ",

		if(self.Next != None):
			self.Next.printList();	
	
class MyList:
	
	def __init__(self):
		self.Head = None;

	def addToEnd(self, data):
		if(self.Head == None):
			self.Head = Node(data);
		else:
			self.Head.addToEnd(data);
	
	def addToBeginning(self, data):
		if(self.Head == None):
			self.Head = Node(data);
		else:
			temp = Node(data);
			temp.Next = self.Head;
			self.Head = temp;		
	
	def addSorted(self, data):
		if(self.Head == None):
			self.Head = Node(data);
		elif(data < self.Head.value):
			self.addToBeginning(data);
		else:
			self.Head.addSorted(data);
	
	def find(self, data):
		if(self.Head == None):
			print "The Head is null"
		else:
			self.Head.find(data, 0);
	
	def minItem(self):
		if(self.Head == None):
			print "The Head is null"
		else:
			self.Head.minItem(self.Head.value);
	
	def maxItem(self):
		if(self.Head == None):
			print "The Head is null"
		else:
			self.Head.maxItem(self.Head.value);
	
	def printList(self):
		self.Head.printList();

myList = MyList()

# myList.addToEnd(5)
# myList.addToEnd(2)
# myList.addToEnd(4)
# myList.addToEnd(8)
# myList.addToEnd(7)
# myList.addToEnd(6)
# myList.addToEnd(11)

# myList.addToBeginning(5)
# myList.addToBeginning(2)
# myList.addToBeginning(4)
# myList.addToBeginning(8)
# myList.addToBeginning(7)
# myList.addToBeginning(6)
# myList.addToBeginning(11)

myList.addSorted(5)
myList.addSorted(2)
myList.addSorted(4)
myList.addSorted(8)
myList.addSorted(7)
myList.addSorted(6)
myList.addSorted(11)

myList.printList()
print ""
myList.find(11)
myList.minItem()
myList.maxItem()