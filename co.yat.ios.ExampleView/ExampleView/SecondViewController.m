//
//  SecondViewController.m
//  ExampleView
//
//  Created by Nic Jackson on 26/01/2013.
//  Copyright (c) 2013 Nic Jackson. All rights reserved.
//

#import "SecondViewController.h"
#import "CentralAccess.h"

@interface SecondViewController ()

@end

@implementation SecondViewController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

-(IBAction)ClickButton: (id)sender {
 
    CentralAccess *access = [CentralAccess GetInstance];
    
    [access SendMessage: @"/SecondViewController/Button/{Click}" json:@"{}"];
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    // Do any additional setup after loading the view from its nib.
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
