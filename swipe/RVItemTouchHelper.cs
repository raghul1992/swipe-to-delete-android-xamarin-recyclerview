<?xml version="1.0" encoding="utf-8"?>
<FrameLayout xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="match_parent"
    android:layout_height="wrap_content">


     <RelativeLayout
                android:background="@android:color/black"

           android:id="@+id/bg_left" 
        android:layout_width="match_parent"
        android:layout_height="match_parent">

          <ImageView
       android:layout_width="wrap_content"
       android:layout_height="wrap_content"
   android:layout_alignParentLeft="true"
        android:src="@drawable/delete"
            android:tint="@android:color/white"
        />

        </RelativeLayout>



    <RelativeLayout
                android:background="@color/bgrow"

           android:id="@+id/bg" 
        android:layout_width="match_parent"
        android:layout_height="match_parent">

          <ImageView
       android:layout_width="wrap_content"
       android:layout_height="wrap_content"
   android:layout_alignParentRight="true"
        android:src="@drawable/delete"
        />

        </RelativeLayout>
   
         <RelativeLayout
           android:id="@+id/fg" 
        android:background="@android:color/white"
        android:layout_width="match_parent"
        android:layout_height="wrap_content">

        <TextView
            android:layout_margin="10dp"
            android:padding="10dp"
            android:textSize="15sp"
       android:layout_width="match_parent"
       android:layout_height="wrap_content"
   android:id="@+id/tv" 
   />
</RelativeLayout>

</FrameLayout>
