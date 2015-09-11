class Node:
	
	def	__init__(self, data):
		self.value = data;
		self.Left = None;
		self.Right = None;
	
	def AddRecursive(self, data):
		if(data > self.value):
			if(self.Right == None):
				self.Right = Node(data);
			else:
				self.Right.AddRecursive(data);
		else:
			if(self.Left == None):
				self.Left = Node(data);
			else:
				self.Left.AddRecursive(data);
		
class MyBst:
	
	def __init__(self):
		self.Top = None;
	
	def AddRecursive(self, data):
		if(self.Top == None):
			self.Top = Node(data);
		else:
			self.Top.AddRecursive(data);
	
	def Add(self, data):
		if(self.Top == None):
			self.Top = Node(data);
		else:
			current = self.Top;
			
			while True:
				if(data > current.value):
					right = current.Right;
					if(right == None):
						right = Node(data);
						current.Right = right;
						return;
					else:
						current = right;
				else:
					left = current.Left;
					if(left == None):
						left = Node(data);
						current.Left = left;
						return;
					else:
						current = left;

	def PreOrderTraverse(self, node):
		if(node != None):
			print str(node.value) + " ",
		if(node != None):
			self.PreOrderTraverse(node.Left);
		if(node != None):
			self.PreOrderTraverse(node.Right);
		return ""; #Without it the print will print out an unexpected "None"
		
	def InOrderTraverse(self, node):
		if(node != None):
			self.InOrderTraverse(node.Left);
		if(node != None):
			print str(node.value) + " ",
		if(node != None):
			self.InOrderTraverse(node.Right);		
		return "";
		
	def PostOrderTraverse(self, node):
		if(node != None):
			self.PostOrderTraverse(node.Left);
		if(node != None):
			self.PostOrderTraverse(node.Right);
		if(node != None):
			print str(node.value) + " ",						
		return "";
		
	def Min(self):
		if(self.Top == None):
			print "The Top is empty";
		else:
			current = self.Top;
			while True:
				if(current.Left == None):
					return current.value;
				else:
					current = current.Left;
					
	def Max(self):
		if(self.Top == None):
			print "The Top is empty";
		else:
			current = self.Top;
			while True:
				if(current.Right == None):
					return current.value;
				else:
					current = current.Right;
			
		
myBst = MyBst();
# myBst.Add(20);
# myBst.Add(25);
# myBst.Add(15);
# myBst.Add(22);
# myBst.Add(45);
# myBst.Add(40);
# myBst.Add(18);
# myBst.Add(13);
# myBst.Add(14);
# myBst.Add(17);
# myBst.Add(1004);

myBst.AddRecursive(20);
myBst.AddRecursive(25);
myBst.AddRecursive(15);
myBst.AddRecursive(22);
myBst.AddRecursive(45);
myBst.AddRecursive(40);
myBst.AddRecursive(18);
myBst.AddRecursive(13);
myBst.AddRecursive(14);
myBst.AddRecursive(17);
myBst.AddRecursive(1004);

print "PreOrderTraverse is: ", myBst.PreOrderTraverse(myBst.Top);
print "InOrderTraverse is: ", myBst.InOrderTraverse(myBst.Top);
print "PostOrderTraverse is: ", myBst.PostOrderTraverse(myBst.Top);
print "The minimum value of the tree is: ", myBst.Min();
print "The maximum value of the tree is: ", myBst.Max();