<<<<<<< .mine
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TiengViet4
{
    public partial class TapDocForm : Form
    {
        public TapDocForm()
        {
            InitializeComponent();
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            btnThanhDieuHuongMatTroi.Visible = false;
            pnlTracNghiem.Expanded = true;
        }

        private void bubbleButton7_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Close();
        }

        private void TapDocForm_Load(object sender, EventArgs e)
        {

        }
    }
}=======
��u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . C o m p o n e n t M o d e l ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D r a w i n g ;  
 u s i n g   S y s t e m . T e x t ;  
 u s i n g   S y s t e m . W i n d o w s . F o r m s ;  
 u s i n g   S y s t e m . I O ;  
 u s i n g   D T O ;  
 u s i n g   B U S ;  
  
 n a m e s p a c e   T i e n g V i e t 4  
 {  
         p u b l i c   p a r t i a l   c l a s s   T a p D o c F o r m   :   F o r m  
         {  
                 p r i v a t e   T a p D o c D T O   t a p D o c D t o ;  
                  
                 p r i v a t e   s t r i n g [ ]   a r r S t r N o i D u n g C a u H o i ;  
                 p r i v a t e   s t r i n g [ ]   a r r S t r N o i D u n g D a p A n ;  
                 i n t   i n t C a u H o i H i e n T a i ;  
                 p r i v a t e   b o o l   b D a n g M o H i n h A n h   =   f a l s e ;  
                 p r i v a t e   F o r m   f r m H i n h A n h ;  
  
                 p u b l i c   T a p D o c F o r m ( s t r i n g   s t r M a B a i H o c ,   F o r m   f r m P a r e n t )  
                 {  
                         I n i t i a l i z e C o m p o n e n t ( ) ;  
  
                         r t b C a u H o i . V i s i b l e   =   f a l s e ;  
  
                         T a p D o c B U S   t a p D o c B u s   =   n e w   T a p D o c B U S ( ) ;  
  
                         t r y  
                         {  
                                 t a p D o c D t o   =   t a p D o c B u s . L a y N o i D u n g B a i H o c ( s t r M a B a i H o c ) ;  
                         }  
                         c a t c h   ( E x c e p t i o n   e x )  
                         {  
                                 M e s s a g e B o x . S h o w ( e x . M e s s a g e ) ;  
                         }  
                
                         N a p B a i H o c ( ) ;  
                         f r m P a r e n t . H i d e ( ) ;  
                          
                 }  
  
                 p r i v a t e   v o i d   N a p B a i H o c ( )  
                 {  
                         i f   ( t a p D o c D t o . D u o n g D a n F i l e N o i D u n g   = =   " " )  
                         {  
                                 r e t u r n ;  
                         }  
                          
                         s t r i n g   s t r N o i D u n g B a i H o c ;  
                         s t r i n g   s t r N o i D u n g T u M o i ;  
  
                         i f   ( F i l e . E x i s t s ( t a p D o c D t o . D u o n g D a n F i l e N o i D u n g )   = =   t r u e )  
                         {  
                                 S t r e a m R e a d e r   s r   =   n e w   S t r e a m R e a d e r ( t a p D o c D t o . D u o n g D a n F i l e N o i D u n g ) ;  
                                 s t r N o i D u n g B a i H o c   =   s r . R e a d T o E n d ( ) ;  
                                 s r . C l o s e ( ) ;  
  
                                 r t b N o i D u n g B a i H o c . R t f   =   s t r N o i D u n g B a i H o c ;  
  
                                 i n t   i n t I n d e x   =   r t b N o i D u n g B a i H o c . T e x t . I n d e x O f ( " \ n \ n \ n " )   +   1 ;  
                                 i f   ( i n t I n d e x   >   0 )  
                                 {  
                                         s t r N o i D u n g T u M o i   =   r t b N o i D u n g B a i H o c . T e x t . S u b s t r i n g ( i n t I n d e x ,   r t b N o i D u n g B a i H o c . T e x t . L e n g t h   -   i n t I n d e x ) ;  
                                         r t b T u M o i . T e x t   =   s t r N o i D u n g T u M o i . R e p l a c e ( " \ n \ n \ n " ,   " " ) ;  
                                         r t b N o i D u n g B a i H o c . S e l e c t ( i n t I n d e x ,   r t b N o i D u n g B a i H o c . T e x t . L e n g t h   -   i n t I n d e x ) ;  
                                         r t b N o i D u n g B a i H o c . C u t ( ) ;  
                                 }  
                                 e l s e  
                                 {  
                                         r t b T u M o i . T e x t   =   " " ;  
                                 }  
                                 r t b N o i D u n g B a i H o c . S e l e c t ( 0 ,   0 ) ;  
                         }  
                         e l s e  
                         {  
                                 M e s s a g e B o x . S h o w ( " K h � n g   t �n   t �i   f i l e   c �n   t h i �t " ) ;  
                         }  
                 }  
                                
                 p r i v a t e   v o i d   b u b b l e B u t t o n 1 _ C l i c k ( o b j e c t   s e n d e r ,   D e v C o m p o n e n t s . D o t N e t B a r . C l i c k E v e n t A r g s   e )  
                 {  
                         / / C �u   h � n h   c � c   c o m p o n e n t  
                         r t b N o i D u n g B a i H o c . H e i g h t   - =   ( r t b C a u H o i . H e i g h t   -   2 0 ) ;  
                         r t b C a u H o i . V i s i b l e   =   t r u e ;  
  
                         / / T h �c   h i �n   c � c   t h a o   t � c                          
                         s t r i n g   s t r E r r   =   " " ;                          
  
                         / / K i �m   t r a   l �i  
                         i f   ( F i l e . E x i s t s ( t a p D o c D t o . D u o n g D a n F i l e C a u H o i )   = =   f a l s e )  
                         {  
                                 s t r E r r   =   " K h � n g   t � m   t h �y   f i l e   c � u   h �i \ n " ;  
                         }  
                         i f   ( F i l e . E x i s t s ( t a p D o c D t o . D u o n g D a n F i l e D a p A n )   = =   f a l s e )  
                         {  
                                 s t r E r r   + =   " K h � n g   t � m   t h �y   f i l e   � p   � n " ;  
                         }  
  
                         i f   ( s t r E r r   = =   " " )  
                         {  
                                 S t r e a m R e a d e r   s r   =   n e w   S t r e a m R e a d e r ( t a p D o c D t o . D u o n g D a n F i l e C a u H o i ) ;  
                                 r t b C a u H o i . R t f   =   s r . R e a d T o E n d ( ) ;  
                                 s r . C l o s e ( ) ;  
  
                                 / / �m   s �  l ��n g   c � u   h �i  
                                 i n t   i n t S o L u o n g C a u H o i   =   0 ;  
                                 f o r   ( i n t   i   =   0 ;   i   <   r t b C a u H o i . T e x t . L e n g t h ;   i + + )  
                                 {  
                                         i f   ( r t b C a u H o i . T e x t [ i ]   = =   ' \ n ' )  
                                         {  
                                                 i n t S o L u o n g C a u H o i + + ;                                                  
                                         }  
                                 }  
  
                                 / / K i �m   t r a   c �   t h i �u   c � u   h �i   h a y   k h � n g  
                                 i f   ( r t b C a u H o i . T e x t [ r t b C a u H o i . T e x t . L e n g t h   -   2 ]   ! =   ' \ n ' )  
                                 {  
                                         i n t S o L u o n g C a u H o i + + ;  
                                         r t b C a u H o i . T e x t   + =   " \ n " ;  
                                 }  
                                  
                                 a r r S t r N o i D u n g C a u H o i   =   n e w   s t r i n g [ i n t S o L u o n g C a u H o i ] ;  
                                 a r r S t r N o i D u n g D a p A n   =   n e w   s t r i n g [ i n t S o L u o n g C a u H o i ] ;  
  
                                 i n t   j   =   0 ;  
  
                                 / / L �y   n �i   d u n g   c h o   t �n g   c � u   h �i  
                                 f o r   ( i n t   i   =   0 ;   i   <   i n t S o L u o n g C a u H o i ;   i + + )  
                                 {  
                                         j   =   r t b C a u H o i . T e x t . I n d e x O f ( " \ n " ) ;  
                                         a r r S t r N o i D u n g C a u H o i [ i ]   =   r t b C a u H o i . T e x t . S u b s t r i n g ( 0 ,   j ) ;  
                                         r t b C a u H o i . T e x t   =   r t b C a u H o i . T e x t . R e p l a c e ( a r r S t r N o i D u n g C a u H o i [ i ]   +   " \ n " ,   " " ) ;  
                                 }  
  
                                 / / L �y   n �i   d u n g   c h o   t �n g   � p   � n  
                                 s r   =   n e w   S t r e a m R e a d e r ( t a p D o c D t o . D u o n g D a n F i l e D a p A n ) ;  
                                 r t b C a u H o i . R t f   =   s r . R e a d T o E n d ( ) ;  
                                 s r . C l o s e ( ) ;  
  
                                 / / T h � m   k �   t �  x u �n g   h � n g   c h o   � p   � n   n �u   t h i �u  
                                 i f   ( r t b C a u H o i . T e x t [ r t b C a u H o i . T e x t . L e n g t h   -   1 ]   ! =   ' \ n ' )  
                                 {  
                                         r t b C a u H o i . T e x t   + =   " \ n " ;  
                                 }  
                                 i f   ( r t b C a u H o i . T e x t [ r t b C a u H o i . T e x t . L e n g t h   -   2 ]   ! =   ' \ n ' )  
                                 {  
                                         r t b C a u H o i . T e x t   + =   " \ n " ;  
                                 }  
  
                                 f o r   ( i n t   i   =   0 ;   i   <   i n t S o L u o n g C a u H o i ;   i + + )  
                                 {  
                                         j   =   r t b C a u H o i . T e x t . I n d e x O f ( " \ n \ n " ) ;  
                                         a r r S t r N o i D u n g D a p A n [ i ]   =   r t b C a u H o i . T e x t . S u b s t r i n g ( 0 ,   j ) ;  
                                         r t b C a u H o i . T e x t   =   r t b C a u H o i . T e x t . R e p l a c e ( a r r S t r N o i D u n g D a p A n [ i ]   +   " \ n \ n " ,   " " ) ;  
                                 }  
                                 i n t C a u H o i H i e n T a i   =   0 ;  
                                 B a t D a u T r a L o i ( ) ;  
                         }  
                         e l s e  
                         {  
                                 M e s s a g e B o x . S h o w ( s t r E r r ,   " C h � o   B � " ) ;  
                         }  
                 }  
  
                 p r i v a t e   v o i d   B a t D a u T r a L o i ( )  
                 {  
                         p i c T D K e t Q u a . V i s i b l e   =   t r u e ;  
                         p i c T D C a u T i e p T h e o . V i s i b l e   =   t r u e ;  
                         p i c T D C a u T r u o c . V i s i b l e   =   t r u e ;  
                         b t n T r a L o i C a u H o i . V i s i b l e   =   f a l s e ;  
                         b t n T h a n h D i e u H u o n g M a t T r o i . V i s i b l e   =   f a l s e ;  
  
                         r t b C a u H o i . F o n t   =   n e w   F o n t ( " T i m e s   N e w   R o m a n " ,   1 4 ) ;  
                         r t b T u M o i . F o n t   =   n e w   F o n t ( " T i m e s   N e w   R o m a n " ,   1 4 ) ;  
                         r t b T u M o i . F o r e C o l o r   =   C o l o r . R e d ;  
                         N a p C a u H o i ( ) ;  
                          
                 }  
  
                 p r i v a t e   v o i d   b u b b l e B u t t o n 7 _ C l i c k ( o b j e c t   s e n d e r ,   D e v C o m p o n e n t s . D o t N e t B a r . C l i c k E v e n t A r g s   e )  
                 {  
                         C l o s e ( ) ;  
                 }  
  
                 p r i v a t e   v o i d   p i c T D K e t Q u a _ M o u s e D o w n ( o b j e c t   s e n d e r ,   M o u s e E v e n t A r g s   e )  
                 {  
                         p i c T D K e t Q u a . B a c k g r o u n d I m a g e   =   P r o p e r t i e s . R e s o u r c e s . k e t q u a 1 ;  
                 }  
  
                 p r i v a t e   v o i d   p i c T D K e t Q u a _ M o u s e U p ( o b j e c t   s e n d e r ,   M o u s e E v e n t A r g s   e )  
                 {  
                         p i c T D K e t Q u a . B a c k g r o u n d I m a g e   =   P r o p e r t i e s . R e s o u r c e s . k e t q u a ;  
                 }  
  
                 p r i v a t e   v o i d   p i c T D C a u T i e p T h e o _ C l i c k ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
                 {  
                         i n t C a u H o i H i e n T a i   =   ( i n t C a u H o i H i e n T a i   +   1 )   %   a r r S t r N o i D u n g C a u H o i . L e n g t h ;  
                         N a p C a u H o i ( ) ;  
                          
                 }  
  
                 p r i v a t e   v o i d   p i c T D C a u T r u o c _ C l i c k ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
                 {  
                    
                         i f   ( i n t C a u H o i H i e n T a i   = =   0 )  
                         {  
                                 i n t C a u H o i H i e n T a i   =   3 ;  
                         }  
                         e l s e  
                         {  
                                 i n t C a u H o i H i e n T a i   - =   1 ;  
                         }  
                         N a p C a u H o i ( ) ;  
                 }  
                  
                 p r i v a t e   v o i d   N a p C a u H o i ( )  
                 {  
                         r t b C a u H o i . T e x t   =   a r r S t r N o i D u n g C a u H o i [ i n t C a u H o i H i e n T a i ] ;  
                         r t b C a u H o i . F o r e C o l o r   =   C o l o r . B l u e ;  
                 }  
  
                 p r i v a t e   v o i d   N a p C a u T r a L o i ( )  
                 {  
                         r t b C a u H o i . T e x t   =   a r r S t r N o i D u n g D a p A n [ i n t C a u H o i H i e n T a i ] ;  
                         r t b C a u H o i . F o r e C o l o r   =   C o l o r . R e d ;  
                          
                 }  
  
                 p r i v a t e   v o i d   p i c T D K e t Q u a _ C l i c k ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
                 {  
                         N a p C a u T r a L o i ( ) ;  
                 }  
  
                 p r i v a t e   v o i d   r t b N o i D u n g B a i H o c _ K e y P r e s s ( o b j e c t   s e n d e r ,   K e y P r e s s E v e n t A r g s   e )  
                 {  
                         e . H a n d l e d   =   t r u e ;  
                 }  
  
                 p r i v a t e   v o i d   r t b N o i D u n g B a i H o c _ K e y D o w n ( o b j e c t   s e n d e r ,   K e y E v e n t A r g s   e )  
                 {  
                         e . H a n d l e d   =   t r u e ;  
                 }  
                            
  
                 p r i v a t e   v o i d   r t b N o i D u n g B a i H o c _ M o u s e C l i c k ( o b j e c t   s e n d e r ,   M o u s e E v e n t A r g s   e )  
                 {  
                         i f   ( r t b N o i D u n g B a i H o c . S e l e c t i o n T y p e   = =   R i c h T e x t B o x S e l e c t i o n T y p e s . O b j e c t   & &   b D a n g M o H i n h A n h   = =   f a l s e )  
                         {  
                                 f r m H i n h A n h   =   n e w   F o r m ( ) ;  
                                 f r m H i n h A n h . T e x t   =   " H i n h   A n h " ;  
                                 f r m H i n h A n h . S i z e   =   n e w   S i z e ( 6 4 0 ,   4 8 0 ) ;  
                                 f r m H i n h A n h . B a c k g r o u n d I m a g e   =   n e w   B i t m a p ( t a p D o c D t o . D u o n g D a n F i l e H i n h A n h ) ;  
                                 f r m H i n h A n h . B a c k g r o u n d I m a g e L a y o u t   =   I m a g e L a y o u t . S t r e t c h ;  
                                 b D a n g M o H i n h A n h   =   t r u e ;  
  
                                 f r m H i n h A n h . S h o w ( ) ;  
                                 f r m H i n h A n h . F o r m C l o s e d   + =   n e w   F o r m C l o s e d E v e n t H a n d l e r ( f r m H i n h A n h _ F o r m C l o s e d ) ;  
                         }  
                         e l s e   i f   ( b D a n g M o H i n h A n h   = =   t r u e )  
                         {  
                                 f r m H i n h A n h . A c t i v a t e ( ) ;  
                         }  
                 }  
  
                 p r i v a t e   v o i d   f r m H i n h A n h _ F o r m C l o s e d ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
                 {  
                         b D a n g M o H i n h A n h   =   f a l s e ;  
                 }  
  
                 p r i v a t e   v o i d   T a p D o c F o r m _ L o a d ( o b j e c t   s e n d e r ,   E v e n t A r g s   e )  
                 {  
  
                 }  
                                  
         }  
 } >>>>>>> .r224
