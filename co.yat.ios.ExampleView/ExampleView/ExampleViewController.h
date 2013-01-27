//
//  ExampleViewController.h
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "SecondViewController.h"

@interface ExampleViewController : UIViewController {

    IBOutlet UIButton * button;

}

-(IBAction)ClickButton: (id)sender;
-(void)GetMessage: (NSString*)uri json: (NSString*)payload;

@end


