When /^I touch the "(.*?)" button$/ do |arg1|
  performAction('press_button_with_text', arg1)
end