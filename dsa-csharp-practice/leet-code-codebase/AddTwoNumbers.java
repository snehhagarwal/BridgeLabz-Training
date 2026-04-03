/**
 * Definition for singly-linked list.
*/
class ListNode {
     int val;
     ListNode next;
     ListNode() {}
     ListNode(int val) { this.val = val; }
     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 }

class AddTwoNumbers {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy=new ListNode(-1);
        ListNode curr=dummy;
        int carry=0;
        //ListNode curr=head;
        while(l1!=null || l2!=null){
            int sum=carry;
            if(l1!=null){
                sum+=l1.val;
                l1=l1.next;
            }
            if(l2!=null){
                sum+=l2.val;
                l2=l2.next;
            }
            ListNode ele=new ListNode(sum%10);
            carry=sum/10;
            curr.next=ele;
            curr=curr.next;           
        }
        if(carry!=0){
            ListNode last=new ListNode(carry);
            curr.next=last;
        }
        return dummy.next;
    }
} 
