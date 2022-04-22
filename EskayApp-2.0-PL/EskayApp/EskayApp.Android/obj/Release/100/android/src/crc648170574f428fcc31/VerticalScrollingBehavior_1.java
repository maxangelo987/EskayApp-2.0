package crc648170574f428fcc31;


public abstract class VerticalScrollingBehavior_1
	extends androidx.coordinatorlayout.widget.CoordinatorLayout.Behavior
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onStartNestedScroll:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)Z:GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler\n" +
			"n_onNestedScrollAccepted:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)V:GetOnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler\n" +
			"n_onStopNestedScroll:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V:GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler\n" +
			"n_onNestedScroll:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIII)V:GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIHandler\n" +
			"n_onNestedPreScroll:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[I)V:GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIHandler\n" +
			"n_onNestedFling:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FFZ)Z:GetOnNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZHandler\n" +
			"n_onNestedPreFling:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FF)Z:GetOnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFHandler\n" +
			"n_onApplyWindowInsets:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;:GetOnApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_Handler\n" +
			"n_onSaveInstanceState:(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Landroid/os/Parcelable;:GetOnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("BottomNavigationBar.Scrollswetness.VerticalScrollingBehavior`1, BottomNavigationBar", VerticalScrollingBehavior_1.class, __md_methods);
	}


	public VerticalScrollingBehavior_1 ()
	{
		super ();
		if (getClass () == VerticalScrollingBehavior_1.class)
			mono.android.TypeManager.Activate ("BottomNavigationBar.Scrollswetness.VerticalScrollingBehavior`1, BottomNavigationBar", "", this, new java.lang.Object[] {  });
	}


	public VerticalScrollingBehavior_1 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == VerticalScrollingBehavior_1.class)
			mono.android.TypeManager.Activate ("BottomNavigationBar.Scrollswetness.VerticalScrollingBehavior`1, BottomNavigationBar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onStartNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, android.view.View p3, int p4)
	{
		return n_onStartNestedScroll (p0, p1, p2, p3, p4);
	}

	private native boolean n_onStartNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, android.view.View p3, int p4);


	public void onNestedScrollAccepted (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, android.view.View p3, int p4)
	{
		n_onNestedScrollAccepted (p0, p1, p2, p3, p4);
	}

	private native void n_onNestedScrollAccepted (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, android.view.View p3, int p4);


	public void onStopNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2)
	{
		n_onStopNestedScroll (p0, p1, p2);
	}

	private native void n_onStopNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2);


	public void onNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, int p3, int p4, int p5, int p6)
	{
		n_onNestedScroll (p0, p1, p2, p3, p4, p5, p6);
	}

	private native void n_onNestedScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, int p3, int p4, int p5, int p6);


	public void onNestedPreScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, int p3, int p4, int[] p5)
	{
		n_onNestedPreScroll (p0, p1, p2, p3, p4, p5);
	}

	private native void n_onNestedPreScroll (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, int p3, int p4, int[] p5);


	public boolean onNestedFling (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, float p3, float p4, boolean p5)
	{
		return n_onNestedFling (p0, p1, p2, p3, p4, p5);
	}

	private native boolean n_onNestedFling (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, float p3, float p4, boolean p5);


	public boolean onNestedPreFling (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, float p3, float p4)
	{
		return n_onNestedPreFling (p0, p1, p2, p3, p4);
	}

	private native boolean n_onNestedPreFling (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, android.view.View p2, float p3, float p4);


	public androidx.core.view.WindowInsetsCompat onApplyWindowInsets (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, androidx.core.view.WindowInsetsCompat p2)
	{
		return n_onApplyWindowInsets (p0, p1, p2);
	}

	private native androidx.core.view.WindowInsetsCompat n_onApplyWindowInsets (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1, androidx.core.view.WindowInsetsCompat p2);


	public android.os.Parcelable onSaveInstanceState (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1)
	{
		return n_onSaveInstanceState (p0, p1);
	}

	private native android.os.Parcelable n_onSaveInstanceState (androidx.coordinatorlayout.widget.CoordinatorLayout p0, android.view.View p1);

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
