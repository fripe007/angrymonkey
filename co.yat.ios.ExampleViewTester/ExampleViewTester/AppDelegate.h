//
//  AppDelegate.h
//  ExampleViewTester
//
//  Created by Nic Jackson on 26/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import <UIKit/UIKit.h>

@class ViewController;
@class CentralAccess;

@interface AppDelegate : UIResponder <UIApplicationDelegate>

@property (strong, nonatomic) UIWindow *window;
@property (nonatomic,retain) CentralAccess *access;
@property (strong, nonatomic) ViewController *viewController;

@end
