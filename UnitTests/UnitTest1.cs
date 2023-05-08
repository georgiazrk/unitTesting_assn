using DoublyLinkedListWithErrors;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class DLLNodeTests
    {
        [TestMethod]
        //Test for prime number
        //Expected: true
        public void Test_isPrime_Prime()
        {
            //Arrange
            DLLNode node = new DLLNode(7);
            //Act and Assert
            Assert.IsFalse((node.isPrime(node.num)));
        }
        [TestMethod]
        //Test for composite number
        //Expected: false
        public void Test_isPrime_Composite()
        {
            //Arrange
            DLLNode node = new DLLNode(6);
            //Act and Assert
            Assert.IsFalse(node.isPrime(node.num));
        }
        [TestMethod]
        //Test for 2, smallest prime number, only even number that is prime, special case.
        //Expected: true
        public void Test_isPrime_2()
        {
            //Arrange
            DLLNode node = new DLLNode(2);
            //Act and Assert
            Assert.IsTrue(node.isPrime(node.num));
        }
        [TestMethod]
        //Test for less than 2
        //Expected: false
        public void Test_isPrime_LessThan2()
        {
            //Arrange
            DLLNode node = new DLLNode(0);
            //Act and Assert
            Assert.IsFalse(node.isPrime(node.num));
        }
        [TestMethod]
        //Test for negative number handling
        //Expected: false
        public void Test_isPrime_NegNum()
        {
            //Arrange
            DLLNode node = new DLLNode(-1);
            //Act and Assert
            Assert.IsFalse(node.isPrime(node.num));
        }
    }
    [TestClass]
    public class DLListTests
    {
        [TestMethod]
        //Test for adding tail to empty list
        //Expected: head and tail values to be same as node value
        public void Test_addToTail_emptyList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode node = new DLLNode(7);
            //Act
            list.addToTail(node);
            //Assert
            Assert.AreEqual(node, list.head);
            Assert.AreEqual(node, list.tail);
        }
        [TestMethod]
        //Test for adding tail to populated list
        //Expected: tail value to be the same as node value, head value to be different
        public void Test_addToTail_populatedList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(2);
            DLLNode p2 = new DLLNode(57);
            DLLNode p3 = new DLLNode(18);
            DLLNode p4 = new DLLNode(29);
            DLLNode p5 = new DLLNode(7);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            list.addToTail(p5);
            //Assert
            Assert.AreEqual(p5, list.tail);
            Assert.AreNotEqual(p5, list.head);
        }
        [TestMethod]
        //Test for adding head to an empty list
        //Expected: head and tail values to be the same as node value
        public void Test_addToHead_emptyList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode node = new DLLNode(57);
            //Act
            list.addToHead(node);
            //Assert
            Assert.AreEqual(node, list.head);
            Assert.AreEqual(node, list.tail);
        }
        [TestMethod]
        //Test for adding head to populated list
        //Expected: head value to be the same as p5 value. tail value to be different.
        public void Test_addToHead_populatedList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(2);
            DLLNode p2 = new DLLNode(57);
            DLLNode p3 = new DLLNode(18);
            DLLNode p4 = new DLLNode(29);
            DLLNode p5 = new DLLNode(98);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            list.addToHead(p5);
            //Assert
            Assert.AreEqual(p5, list.head);
            Assert.AreNotEqual(p5, list.tail);
        }
        [TestMethod]
        //Test to remove head of list with 1 element.
        //Expected: head is null
        public void Test_removeHead_singleElement()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p = new DLLNode(2);
            list.addToHead(p);
            //Act
            list.removeHead();
            //Assert
            Assert.IsNull(list.head);
        }
        [TestMethod]
        //Test to remove head of list with mulitple elements.
        //Expected: head equals new head value.
        public void Test_removeHead_populatedList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(6);
            DLLNode p2 = new DLLNode(81);
            DLLNode p3 = new DLLNode(92);
            DLLNode p4 = new DLLNode(17);
            DLLNode p5 = new DLLNode(98);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            list.addToTail(p5); //6, 81, 92, 17, 98
            //Act
            list.removeHead();
            //Assert
            Assert.AreEqual(p2, list.head);
        }
        [TestMethod]
        //Test to remove head from empty list.
        //Expected: head and tail to be null.
        public void Test_removeHead_emptyList()
        {
            //Arrange
            DLList list = new DLList();
            //Act
            list.removeHead();
            //Assert
            Assert.IsNull(list.head);
            Assert.IsNull(list.tail);
        }
        [TestMethod]
        //Test to remove tail of list with 1 element.
        //Expected: tail and head to be null.
        public void Test_removeTail_singleElement()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p = new DLLNode(92);
            list.addToHead(p);
            //Act
            list.removeTail();
            //Assert
            Assert.IsNull(list.tail);
            Assert.IsNull(list.head);
        }
        [TestMethod]
        //Test to remove tail of list with more than 1 element.
        //Expected: tail equals new tail value
        public void Test_removeTail_populatedList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(67);
            DLLNode p2 = new DLLNode(3);
            DLLNode p3 = new DLLNode(82);
            DLLNode p4 = new DLLNode(17);
            DLLNode p5 = new DLLNode(87);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            list.addToTail(p5); //67, 3, 82, 17, 87
            //Act
            list.removeTail();
            //Assert
            Assert.AreEqual(list.tail, p4);
        }
        [TestMethod]
        //Test to search an empty list.
        //Expected: node to be null
        public void Test_search_emptyList()
        {
            //Arrange
            DLList list = new DLList();
            //Act
            DLLNode node = list.search(9);
            //Assert
            Assert.IsNull(node);
        }
        [TestMethod]
        //Test to search list with 1 element, a number that is in the list.
        //Expected: search is correct.
        public void Test_search_singleElementCorrect()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            list.addToTail(p1);
            //Act
            DLLNode node = list.search(17);
            //Assert
            Assert.AreEqual(p1, node);
        }
        [TestMethod]
        //Test to search list with 1 element, a node that is not in the list.
        //Expected: search returns null
        public void Test_search_singleElementIncorrect()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            list.addToTail(p1);
            //Act
            DLLNode node = list.search(8);
            //Assert
            Assert.IsNull(node);
        }
        [TestMethod]
        //Test to search list with more than 1 element, a number that is in the list
        //Expected: search correct, node matches searched node.
        public void Test_search_largeListCorrect()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(23);
            DLLNode p3 = new DLLNode(45);
            DLLNode p4 = new DLLNode(71);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            DLLNode node = list.search(23);
            //Assert
            Assert.AreEqual(p2, node);
        }
        [TestMethod]
        //Test to search list with more than 1 element, number that is not in the list
        //Expected: search incorrect, null node
        public void Test_search_largeListIncorrect()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(45);
            DLLNode p3 = new DLLNode(67);
            DLLNode p4 = new DLLNode(2);
            list.addToTail(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            DLLNode node = list.search(8);
            //Assert
            Assert.IsNull(node);
        }
        [TestMethod]
        //Test for removing a tail node
        //Expected: new tail node to be updated to previous node.
        public void Test_removeNode_tail()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(45);
            DLLNode p3 = new DLLNode(67);
            DLLNode p4 = new DLLNode(2);
            list.addToTail(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            list.removeNode(p4);
            //Assert
            Assert.AreEqual(p3, list.tail);
        }
        [TestMethod]
        //Test for removing a head node
        //Expected: new head node to be updated to next node
        public void Test_removeNode_head()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(45);
            DLLNode p3 = new DLLNode(67);
            DLLNode p4 = new DLLNode(2);
            list.addToTail(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            //Act
            list.removeNode(p1);
            //Assert
            Assert.AreEqual(p2, list.head);
        }
        [TestMethod]
        //Test for removing a node in the middle of a list
        //Expected: node before removed node now points to node after removed node.
        public void Test_removeNode_middle()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(45);
            DLLNode p3 = new DLLNode(67);
            DLLNode p4 = new DLLNode(2);
            DLLNode p5 = new DLLNode(7);
            list.addToTail(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            list.addToTail(p5);
            //Act
            list.removeNode(p3);
            //Assert
            Assert.AreEqual(p2.next, p4);
            Assert.AreEqual(p4.previous, p2);
        }
        [TestMethod]
        //Test to find the total of an empty list
        //Expected: return value = 0
        public void Test_total_emptyList()
        {
            //Arrange
            DLList list = new DLList();
            //Act
            int result = list.total();
            //Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        //Test to find total of a list with 1 element
        //Expected: return value = value of element
        public void Test_total_singleElement()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p = new DLLNode(17);
            list.addToHead(p);
            //Act
            int result = list.total();
            //Assert
            Assert.AreEqual(result, p.num);
        }
        [TestMethod]
        //Test to find total of a list with more than 1 element
        //Expected: correct total value
        public void Test_total_populatedList()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(17);
            DLLNode p2 = new DLLNode(6);
            DLLNode p3 = new DLLNode(89);
            DLLNode p4 = new DLLNode(76);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            int expected = p1.num + p2.num + p3.num + p4.num;
            //Act
            int result = list.total();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        //Test to find total of a list containing only negative numbers
        //Expected: correct total value
        public void Test_total_negNums()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(-5);
            DLLNode p2 = new DLLNode(-2);
            list.addToHead(p1);
            list.addToTail(p2);
            int expected = p1.num + p2.num;
            //Act
            int result = list.total();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        //Test to find total of a list containing both negative and positive numbers
        //Expected: correct total value
        public void Test_total_negPosNums()
        {
            //Arrange
            DLList list = new DLList();
            DLLNode p1 = new DLLNode(-500);
            DLLNode p2 = new DLLNode(-2);
            DLLNode p3 = new DLLNode(600);
            DLLNode p4 = new DLLNode(5);
            list.addToHead(p1);
            list.addToTail(p2);
            list.addToTail(p3);
            list.addToTail(p4);
            int expected = p1.num + p2.num + p3.num + p4.num;
            //Act
            int result = list.total();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}