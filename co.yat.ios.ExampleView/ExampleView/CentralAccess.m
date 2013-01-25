//
//  CentralAccess.m
//  ExampleView
//
//  Created by Nic Jackson on 25/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import "CentralAccess.h"
#import "ExampleViewController.h"

@implementation CentralAccess

-(id)init {
    
    self = [super init];
    
    if(self) {
        
        NSLog(@"Init Application");
        self.window = [[[UIWindow alloc] initWithFrame:[[UIScreen mainScreen] bounds]] autorelease];
        // Override point for customization after application launch.
        self.viewController = [[[ExampleViewController alloc] initWithNibName:@"ExampleViewController" bundle:nil] autorelease];
        self.window.rootViewController = self.viewController;
        [self.window makeKeyAndVisible];
    }
    
    return self;
    
}

@end
