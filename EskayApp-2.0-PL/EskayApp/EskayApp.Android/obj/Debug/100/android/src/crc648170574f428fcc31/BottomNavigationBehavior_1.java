package crc648170574f428fcc31;


public class BottomNavigationBehavior_1
	extends crc648170574f428fcc31.VerticalScrollingBehavior_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_layoutDependsOn:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z:GetLayoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler\n" +
			"n_onDependentViewRemoved:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V:GetOnDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler\n" +
			"n_onDependentViewChanged:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z:GetOnDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("BottomNavigationBar.Scrollswetness.BottomNavigationBehavior`1, BottomNavigationBar", BottomNavigationBehavior_1.class, __md_methods);
	}


	public BottomNavigationBehavior_1 ()
	{
		super ();
		if (getClass () == BottomNavigationBehavior_1.class)
			mono.android.TypeManager.Activate ("BottomNavigationBar.Scrollswetness.BottomNavigationBehavior`1, BottomNavigationBar", "", this, new java.lang.Object[] {  });
	}


	public BottomNavigationBehavior_1 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == BottomNavigationBehavior_1.class)
			mono.android.TypeManager.Activate ("BottomNavigationBar.Scrollswetness.BottomNavigationBehavior`1, BottomNavigationBar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean layoutDependsOn (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2)
	{
		return n_layoutDependsOn (p0, p1, p2);
	}

	private native boolean n_layoutDependsOn (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2);


	public void onDependentViewRemoved (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2)
	{
		n_onDependentViewRemoved (p0, p1, p2);
	}

	private native void n_onDependentViewRemoved (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2);


	public boolean onDependentViewChanged (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2)
	{
		return n_onDependentViewChanged (p0, p1, p2);
	}

	private native boolean n_onDependentViewChanged (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
