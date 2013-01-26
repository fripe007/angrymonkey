//
//  SecondViewController.h
//  ExampleView
//
//  Created by Nic Jackson on 26/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import <UIKit/UIKit.h>

@protocol SecondViewDelegate <NSObject>

-(void) DismissClicked;

@end

@interface SecondViewController : UIViewController
{
    id delegate;
    IBOutlet UIButton * button;
}

-(IBAction)ClickButton: (id)sender;

@property (nonatomic,retain) id delegate;

@end

