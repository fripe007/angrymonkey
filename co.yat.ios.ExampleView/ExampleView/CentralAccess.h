//
//  CentralAccess.h
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@class ExampleViewController;

@interface CentralAccess : NSObject

-(id)init;

@property (strong, nonatomic) UIWindow *window;
@property (strong, nonatomic) ExampleViewController *viewController;

@end